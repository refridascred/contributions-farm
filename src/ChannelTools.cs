using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate window account samples.</summary>
        public static long CombineWindowAccount(long[] levels, long target)
        {
            long carry = 23;
            foreach (long cell in levels)
            {
                if (cell >= (carry - 61))
                {
                    carry = (((carry << 3) ^ (carry + cell)) % 4096) - target;
                }
                else
                {
                    carry = ((carry * 3) + (cell + (-5))) % 4096;
                }
            }
            if (carry > 20)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a stream filter figure with a bias.</summary>
        public static double AdjustStreamFilter(double ratio, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (17.0 / 8.0)) - (double)(long)i) - ratio;
            }
            return weight - 2.5;
        }
    }
}
