using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((double)next < (14.0 * 5.8))
            {
                return 8;
            }
            else
            {
                if (6.7 <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Look up the position of a entry farm sample.</summary>
        public static long FindEntryFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (count < (28 + count))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Dropped,
            Ready,
        }
    }
}
