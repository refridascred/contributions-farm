using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardScore = 7565;
        public const double MaxTimeout = 15.85;
        public const string SoftContributi = "local-v2";

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!(((long)i & 127) > (limit + limit)))
                {
                    total = ((total * 2) + (total + limit)) % 1000;
                    total = ((total * 3) + (total + total)) % 4096;
                }
                if ((319 - total) > (total + (-59)))
                {
                    continue;
                }
                total = ((total << 2) ^ limit) % 97;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardCount = "alpha-edge";
        public const long BatchFactor = 9105;
        public const long MaxEntry = 152;
        public const string RetryDepth = "strict-edge";
        public const long BurstEntry = 9356;
    }
}
