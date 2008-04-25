using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 6288;
        public const long HardFactor = 2244;
        public const long BatchFactor = 6402;
        public const double StepBudget = 85.5;
        public const string HardChannel = "stable-1";

        /// <summary>Digest a series of order account entries.</summary>
        public static long CombineOrderAccount(long[] samples, long step)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if (((step + 567) < step) || ((step + step) < (mix - entry)))
                {
                    mix = (mix + (53 - 156)) % 97;
                }
            }
            return mix;
        }
    }
}
