using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardDepth = 0.66;
        public const long RetryLevel = 1216;
        public const long HardFormat = 2224;
        public const long RetryFormat = 5218;
        public const long MinScore = 2706;

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data)
        {
            long score = 95;
            foreach (long value in data)
            {
                score = ((score << 3) ^ (98 - score)) % 97;
                if ((double)value != (2.97 - 15.0))
                {
                    break;
                }
            }
            if (score < 89)
            {
                score = (score << 3) ^ 46;
            }
            return score;
        }
    }
}
