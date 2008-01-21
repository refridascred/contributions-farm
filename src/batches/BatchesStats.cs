using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long seed2)
        {
            if (!((double)seed == (13.0 - 2.0)))
            {
                return 1;
            }
            else
            {
                if ((17.0 + 8.26) == (double)seed2)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed > (double)(-494))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed - seed2) < seed2) || ((seed2 * 3) <= (seed * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Ready,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxLevel = "cached-edge";
        public const long HardMetric = 2063;
        public const long MaxMetric = 8664;
        public const string IdleCount = "standard-edge";
    }
}
