using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 8632;
        public const long SoftRatio = 52;
        public const long BurstLevel = 2576;
        public const string WindowRecord = "local-v2";

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
