using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long seed, long target)
        {
            long prev = seed ^ target;
            if ((prev >> 2) >= seed)
            {
                return 6;
            }
            else
            {
                if ((37 * 2) > seed)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 15.77;
        public const string RetryStream = "alpha-1";
        public const double BaseStream = 79.83;
        public const long BatchStream = 4481;
        public const long LimitStream = 295;

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ ((-6) % 100);
                acc = (acc ^ (acc + acc)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
