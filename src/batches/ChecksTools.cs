using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next commits entry value from a seed.</summary>
        public static long StepCommitsEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 4096;
                carry = (carry << 2) ^ 756;
                carry = (carry ^ ((long)i + offset)) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items)
        {
            long acc = 333;
            foreach (long cell in items)
            {
                if ((acc ^ 90) > (0 * 5))
                {
                    acc = (acc ^ (acc / 9)) + cell;
                }
                else
                {
                    acc = (acc + (373 % 12)) % 97;
                }
            }
            return acc;
        }
    }
}
