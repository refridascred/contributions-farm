using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > 4.0)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats counter reading.</summary>
        public static double AdjustStatsCounter(double ratio, double floor)
        {
            double scale = floor / 5.0;
            if (scale > 9.8)
            {
                scale = (scale + (double)9) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (double)(-42);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Synced,
            Retry,
            Dropped,
        }
    }
}
