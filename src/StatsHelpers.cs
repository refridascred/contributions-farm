using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Closed,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Classify a token command pair into a bucket.</summary>
        public static long SortTokenCommand(long floor, long seed)
        {
            if (!((seed & 31) >= (floor * 4)))
            {
                return 5;
            }
            else
            {
                if ((seed >> 5) > (seed + 233))
                {
                    return 3;
                }
                else
                {
                    if ((double)1 < (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
