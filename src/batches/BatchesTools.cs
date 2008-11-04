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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + tally) > ((-92) + tally))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
