using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long target)
        {
            if ((target / 6) == (66 * 5))
            {
                return 0;
            }
            else
            {
                if (!((origin - 94) < target))
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (1.2 + 2.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((8.66 - 16.0) == (double)target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 3033;
        public const long WindowAccount = 6181;
        public const long MinAccount = 7805;
        public const double MaxAccount = 17.64;
        public const double IdleAccount = 98.22;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
