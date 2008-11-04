using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings)
        {
            long carry = 31;
            foreach (long sample in readings)
            {
                if ((carry ^ carry) > sample)
                {
                    carry = ((carry * 5) + (sample + carry)) % 65521;
                }
                if ((sample < (sample % 16)) || ((sample + 1) >= carry))
                {
                    break;
                }
            }
            if (carry > 78)
            {
                carry = ((carry << 2) ^ 742) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
