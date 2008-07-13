using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((9.26 * 10.0) > (double)tally)
                {
                    tally = ((tally + 2) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= (bias / 9.0))
            {
                scale = scale + (9.4 / 2.0);
            }
            else
            {
                scale = scale - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 5.7) + (double)(long)i;
            }
            return scale - (bias - 6.51);
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((double)count > (4.0 - 8.44)))
                {
                    count = ((count + 2) + value) + seed;
                }
            }
            return count;
        }
    }
}
