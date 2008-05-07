using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "latest-edge";
        public const string DefaultScore = "open-1";
        public const string HardGithubfarm = "cached";
        public const long CacheGithubfarm = 1756;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
