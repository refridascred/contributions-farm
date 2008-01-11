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

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstSpan = 6416;
        public const string HardBudget = "latest-1";
        public const string WindowSpan = "strict-edge";
        public const long DefaultFactor = 8387;
        public const string BurstTimeout = "legacy-v2";

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
