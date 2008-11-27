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

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Failed,
            Closed,
            Pending,
            Dropped,
        }

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
