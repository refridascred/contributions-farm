using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 60.91;
        public const string RetryBudget = "local";
        public const long BatchSize = 109;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 3) ^ (limit >> 2);
                anchor = anchor ^ (anchor - limit);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long offset, long seed)
        {
            long step = offset + seed;
            if ((4 + seed) >= step)
            {
                return 2;
            }
            else
            {
                if (((step + (-8)) >= (offset % 7)) || ((double)offset == (double)0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 31;
            foreach (long item in levels)
            {
                carry = (((carry * 3) + (carry % 3)) % 65521) ^ item;
            }
            if (carry > 8)
            {
                carry = ((carry << 2) ^ (carry >> 1)) % 65521;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 95.86;
        public const long HardSpan = 1137;
        public const long SoftEntry = 9441;
        public const long HardBudget = 8090;
        public const long BatchEntry = 1091;
    }
}
