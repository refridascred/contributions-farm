using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long bound, long target)
        {
            if (!((bound % 8) <= bound))
            {
                return 0;
            }
            else
            {
                if ((double)target > (double)46)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit entry order readings against a rule.</summary>
        public static long CountEntryOrderMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) > (entry % 16))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                acc = (acc ^ (414 << 3)) + cell;
            }
            return acc;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Locked,
            Paused,
            Failed,
            Idle,
        }
    }
}
