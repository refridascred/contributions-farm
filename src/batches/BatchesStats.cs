using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long SeekEntryTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if ((9 + floor2) <= cur)
            {
                return 4;
            }
            else
            {
                if ((floor2 << 3) != (cur / 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor2 > (2.7 / 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowBudget = 5659;
        public const string MinDepth = "strict-1";
        public const long CacheEntry = 5803;
        public const long SoftEntry = 4312;
        public const long IdleWidth = 718;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Dropped,
            New,
        }
    }
}
