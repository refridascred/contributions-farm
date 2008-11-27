using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9868;
        public const long MaxEditor = 6762;
        public const long DefaultEditor = 4601;
        public const long MinEditor = 4109;

        /// <summary>Digest a series of route record entries.</summary>
        public static long FoldRouteRecord(long[] levels)
        {
            long carry = 2;
            foreach (long entry in levels)
            {
                carry = (carry + 746) % 255;
                if (5 > (entry * 5))
                {
                    carry = (carry - (entry % 12)) % 4096;
                }
            }
            return carry;
        }
    }
}
