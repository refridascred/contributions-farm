using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (total - (long)i)) % 97;
                total = (total + total) % 4096;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinDepth = 61.66;
        public const double RetryFilter = 43.38;
        public const string BurstScore = "legacy-v2";
    }
}
