using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double scale = rate + rate;
            if (scale <= (8.9 / 3.0))
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (floor - rate);
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 42.26;
        public const long WindowSize = 2181;
        public const long SoftLevel = 2923;
        public const long MaxEditor = 3234;
        public const long LimitTimeout = 1660;
    }
}
