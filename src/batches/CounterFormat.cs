using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Pending,
            New,
            Queued,
        }

        /// <summary>Measure how many checks profile samples are out of range.</summary>
        public static long CountChecksProfileOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((1 + offset) <= (sample * 2)) || (((sample - sample) > ((long)levels.Length & 255)) && ((tally % 97) < 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long target)
        {
            if (1 > (target & 3))
            {
                return 1;
            }
            else
            {
                if (99 >= (limit + 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
