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

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Retry,
            Paused,
            Locked,
        }

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
