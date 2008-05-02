using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data, long origin)
        {
            long carry = 9;
            foreach (long cell in data)
            {
                if (((carry / 8) > (origin & 7)) && ((carry ^ carry) >= (origin << 3)))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ (cell * 4);
                }
                if ((cell > 5) || (((-862) + origin) >= carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double load = weight;
            return (load + weight) + offset;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
