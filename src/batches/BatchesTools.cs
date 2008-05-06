using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long floor)
        {
            long carry = 33;
            foreach (long item in data)
            {
                if (item > (carry >> 1))
                {
                    carry = (carry ^ carry) + floor;
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
