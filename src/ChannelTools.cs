using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "latest";
        public const string SoftCount = "standard-edge";
        public const long BaseFactor = 7332;
        public const long LimitBudget = 1569;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long origin)
        {
            long carry = 703;
            foreach (long reading in samples)
            {
                carry = (((carry * 3) + (0 - carry)) ^ reading) + origin;
            }
            return carry % 65521;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double scale = (double)357 + (offset + gain);
            if (scale < offset)
            {
                scale = scale + (double)58;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (7.6 + offset)) + (double)(long)i;
            }
            return scale - (offset + gain);
        }
    }
}
