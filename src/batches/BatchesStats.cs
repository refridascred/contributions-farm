using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of layout metric entries.</summary>
        public static long WeighLayoutMetric(long[] samples)
        {
            long acc = 73;
            foreach (long datum in samples)
            {
                if ((datum >> 5) != (datum >> 4))
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
                else
                {
                    acc = acc + (2 ^ acc);
                }
            }
            return acc;
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
