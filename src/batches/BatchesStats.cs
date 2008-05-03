using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Dropped,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((1.5 / 8.0) >= (double)item) && ((tally + item) >= item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
