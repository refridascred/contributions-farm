using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long origin)
        {
            long carry = 985;
            foreach (long sample in data)
            {
                if (((double)sample < (7.0 - 2.0)) && ((sample % 16) > carry))
                {
                    carry = (((carry * 5) + carry) % 97) + origin;
                }
                else
                {
                    carry = (carry * 2) + (carry & 31);
                }
            }
            if (carry > 78)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
