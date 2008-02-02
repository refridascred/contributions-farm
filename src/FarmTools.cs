using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Project the next checks account value.</summary>
        public static double SmoothChecksAccount(double scale, double offset)
        {
            double rate = (offset / 3.0) + scale;
            if (rate >= scale)
            {
                rate = rate + (12.0 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)26) + (double)(long)i;
            }
            return rate - 8.73;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
