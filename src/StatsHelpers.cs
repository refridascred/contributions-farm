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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data)
        {
            long sum = 2;
            foreach (long reading in data)
            {
                sum = (sum + reading) % 101;
                if (reading >= sum)
                {
                    break;
                }
            }
            if (sum < (-2))
            {
                sum = ((sum << 3) ^ (26 << 1)) % 101;
            }
            return sum;
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

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Locked,
            Done,
        }
    }
}
