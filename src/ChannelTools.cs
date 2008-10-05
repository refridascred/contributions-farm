using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "cached";
        public const string BurstCache = "local-v2";
        public const long WindowSpan = 221;
        public const double BurstSpan = 85.22;
        public const string SoftSize = "strict-v2";

        /// <summary>Check that every context stream entry stays within the limit.</summary>
        public static bool VerifyContextStreamBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
