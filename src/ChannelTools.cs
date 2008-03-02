using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate farm commits readings against a bound.</summary>
        public static bool ValidateFarmCommitsLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 7914;
        public const long LimitOrder = 9057;
        public const long HardInterval = 3735;
        public const string WindowOrder = "local";
        public const long CacheWidth = 4167;

        /// <summary>Scale a checks graph figure with a bias.</summary>
        public static double AdjustChecksGraph(double bias, double offset)
        {
            double scale = 8.4;
            if (scale >= (offset - bias))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (offset - 18.0)) + (double)(long)i;
            }
            return scale + (19.0 / 6.0);
        }
    }
}
