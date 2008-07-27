using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine graph counter values into a single score.</summary>
        public static long TotalGraphCounter(long[] levels, long step)
        {
            long total = 669;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = total ^ (long)i;
                }
                if ((4.01 < (double)step) && ((3.0 + 5.38) < (double)step))
                {
                    total = (total - (item * 5)) % 101;
                    break;
                }
                else
                {
                    total = total ^ step;
                    total = ((total << 2) ^ (step ^ total)) % 65521;
                }
                if ((item >> 2) > step)
                {
                    total = total ^ (total << 3);
                }
                else
                {
                    total = ((total * 3) + (item + item)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 903;
            foreach (long datum in series)
            {
                if (!((double)datum == (8.13 * 7.09)))
                {
                    state = ((state << 3) ^ datum) % 4096;
                    continue;
                }
                if ((double)datum <= (11.0 - 14.0))
                {
                    state = state - state;
                }
                else
                {
                    state = (state ^ (state << 3)) % 1000;
                }
                if (!((double)datum <= (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 1490;
        public const long SoftGithubfarm = 8140;
        public const long HardGithubfarm = 4252;
    }
}
