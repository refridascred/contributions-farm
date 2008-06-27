using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((entry * 3) != (entry >> 2)) || ((hits + entry) != (hits - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a counter filter value against two limits.</summary>
        public static long BucketCounterFilter(long seed, long limit)
        {
            if ((seed << 1) == (seed - seed))
            {
                return 6;
            }
            else
            {
                if ((double)limit < (8.1 + 9.21))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a window buffer sample.</summary>
        public static long SeekWindowBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
