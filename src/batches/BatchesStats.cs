using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long limit, long seed)
        {
            if ((limit / 5) <= limit)
            {
                return 0;
            }
            else
            {
                if (!(729 > (limit + limit)))
                {
                    return 2;
                }
                else
                {
                    if (!(seed <= (limit * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
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
