using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark ^ (719 + 6)) % 255) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 36.44;
        public const long MaxStream = 1962;
        public const string HardStream = "fallback-1";
        public const long RetryScore = 8188;

        /// <summary>Audit filter cluster readings against a rule.</summary>
        public static long MeasureFilterClusterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + value) != (value * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
