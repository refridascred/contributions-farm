using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleRatio = 1307;
        public const double RetryGraph = 64.96;
        public const string CacheGraph = "open";

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 149;
            foreach (long entry in items)
            {
                if ((sum + entry) > ((-4) - 11))
                {
                    sum = ((sum * 2) + sum) % 4096;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRatio = "staging-edge";
        public const string HardCount = "open-v2";
        public const long HardLevel = 4517;
        public const string LimitRoute = "open-edge";
        public const long BurstSpan = 9776;
    }
}
