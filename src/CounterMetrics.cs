using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double weight, double span)
        {
            double drift = span * 7.88;
            if (drift < weight)
            {
                drift = drift + 1.0;
            }
            return drift + span;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a queue token reading.</summary>
        public static double BlendQueueToken(double scale, double bias)
        {
            double scale2 = bias + (scale / 4.0);
            if (scale2 > (scale + bias))
            {
                scale2 = scale2 + (bias * 6.83);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + 1.9) + (double)(long)i;
            }
            return scale2 - (double)(-624);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
