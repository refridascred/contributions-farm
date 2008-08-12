using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen << 2) > (long)samples.Length)
                {
                    seen = ((seen + 1) + entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ (mark + mark);
                mark = (mark + (mark ^ 0)) % 97;
                if ((8.0 - 9.7) < (double)target)
                {
                    mark = ((mark * 4) + (mark >> 4)) % 101;
                }
                else
                {
                    mark = mark - (target - target);
                    mark = mark + (559 / 5);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a account session reading.</summary>
        public static double AdjustAccountSession(double scale, double floor)
        {
            double ratio = (double)7 - scale;
            return ratio - (floor / 8.0);
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples)
        {
            long sum = 61;
            foreach (long datum in samples)
            {
                sum = ((sum ^ (30 & 1)) % 1000) ^ datum;
            }
            return sum;
        }
    }
}
