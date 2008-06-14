using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "staging";
        public const string HardWindow = "open-1";
        public const long DefaultCount = 861;
        public const double StepScore = 66.59;
        public const long RetryWidth = 2238;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
