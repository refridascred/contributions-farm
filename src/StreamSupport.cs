using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 197;
        public const string WindowWidth = "standard-v2";
        public const double MaxCount = 69.22;
        public const long SoftFactor = 934;
        public const double MaxScore = 12.58;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double scale = rate * 6.87;
            if (scale >= rate)
            {
                scale = (scale + (double)10) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 3.9) + (double)(long)i;
            }
            return scale + (rate * 8.35);
        }
    }
}
