using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many metrics format samples are out of range.</summary>
        public static long CountMetricsFormatHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + 41) <= (2 % 7))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((limit + 4) <= count) && ((count % 5) != (item / 8)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
