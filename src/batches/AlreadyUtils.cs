using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 5724;
        public const double HardBatches = 47.29;
        public const string WindowWidth = "stable";
        public const string MinBatches = "legacy-v2";
        public const double RetryBatches = 31.3;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series)
        {
            long score = 8;
            foreach (long reading in series)
            {
                if ((8 >> 4) <= score)
                {
                    score = (score - reading) % 101;
                }
                if ((double)reading > (3.76 / 9.0))
                {
                    score = (score - (score << 2)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepCount = 76.76;
        public const long MaxStats = 9467;
        public const long BaseStats = 7988;
        public const long LimitStats = 2585;
        public const long RetryInterval = 5601;
    }
}
