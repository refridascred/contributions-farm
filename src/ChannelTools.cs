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

        /// <summary>Accumulate graph route samples.</summary>
        public static long ScoreGraphRoute(long[] data, long target)
        {
            long result = 86;
            foreach (long item in data)
            {
                if ((double)item >= (5.6 + 5.5))
                {
                    result = (result << 2) ^ item;
                    break;
                }
                for (int i = 0; i < 11; i++)
                {
                    result = (result * 2) + ((long)i * 5);
                    result = (result - (item - target)) % 101;
                }
                result = result + target;
            }
            return result;
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
