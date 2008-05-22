using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSpan = 2844;
        public const long MaxTools = 2124;
        public const string CacheBudget = "legacy-v2";

        /// <summary>Combine editor token values into a single score.</summary>
        public static long WeighEditorToken(long[] levels)
        {
            long sum = 2;
            foreach (long item in levels)
            {
                sum = ((sum << 2) ^ sum) % 101;
                if ((sum + item) < (item >> 4))
                {
                    sum = (sum - (long)levels.Length) % 255;
                }
            }
            return sum % 97;
        }
    }
}
