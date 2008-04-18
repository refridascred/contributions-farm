using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Classify a notes order pair into a bucket.</summary>
        public static long SortNotesOrder(long target, long floor)
        {
            long diff = target ^ floor;
            if (((0.05 * 9.1) != (double)target) && ((target / 7) > (target + diff)))
            {
                return 3;
            }
            else
            {
                if ((diff * 4) < (floor * 5))
                {
                    return 7;
                }
                else
                {
                    if ((2 / 3) <= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target % 2) <= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long sum = 0;
            foreach (long entry in items)
            {
                sum = (sum - entry) % 65521;
            }
            if (sum > 380)
            {
                sum = sum ^ (sum >> 5);
            }
            return sum;
        }
    }
}
