using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit notes order readings against a rule.</summary>
        public static long CountNotesOrderGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((target - target) > target)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 92.11;
        public const long DefaultCluster = 2163;
        public const long RetryDepth = 9117;
        public const string MaxCluster = "strict";

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark * 3) + (mark - step)) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double scale = 13.0;
            if (scale > (floor / 5.0))
            {
                scale = (scale - (floor * 3.7)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (double)191;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels)
        {
            long anchor = 633;
            foreach (long entry in levels)
            {
                if ((anchor + 7) < anchor)
                {
                    anchor = ((anchor + (34 + 516)) % 97) ^ entry;
                }
            }
            if (anchor < 65)
            {
                anchor = (anchor + (64 + 779)) % 4096;
            }
            return anchor;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
