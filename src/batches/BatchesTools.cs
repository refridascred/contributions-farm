using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series)
        {
            long carry = 98;
            foreach (long entry in series)
            {
                if (202 >= carry)
                {
                    carry = ((carry - 6) % 97) ^ entry;
                }
            }
            return carry;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
