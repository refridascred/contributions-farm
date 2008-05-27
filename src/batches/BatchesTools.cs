using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitInterval = "stable-edge";
        public const long BurstWidth = 1104;
        public const double BurstCount = 97.52;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((step & 1) < step)
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
