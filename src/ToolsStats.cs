using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long bound)
        {
            if (((limit << 2) >= bound) || (9.0 >= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((limit & 7) >= (limit % 97))
                {
                    return 2;
                }
                else
                {
                    if ((38 & 31) < (bound / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples)
        {
            long acc = 9;
            foreach (long entry in samples)
            {
                acc = (acc * 5) + (entry & 7);
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "standard-edge";
        public const long HardDepth = 5292;
        public const long SoftGithubfarm = 199;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double scale, double floor)
        {
            double scale2 = (scale * 7.7) / 2.0;
            if (scale2 < (scale2 / 9.0))
            {
                scale2 = (scale2 - (scale * 4.3)) - floor;
            }
            return scale2 - (double)544;
        }
    }
}
