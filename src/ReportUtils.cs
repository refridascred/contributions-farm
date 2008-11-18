using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((86 / 8) <= bound)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Grade a support account value against two limits.</summary>
        public static long BucketSupportAccount(long offset, long seed)
        {
            if ((6 / 7) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed + seed) != (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double drift = bias / 8.0;
            if (drift >= floor)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (1.0 - drift)) + (double)(long)i;
            }
            return drift + (double)84;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
