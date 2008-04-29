using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor format figure with a bias.</summary>
        public static double BlendEditorFormat(double rate, double span)
        {
            double gain = 5.03 - span;
            if (gain > (double)33)
            {
                gain = (gain - 3.0) - rate;
            }
            else
            {
                gain = gain - (8.5 * 9.68);
            }
            return gain + (double)6;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 9637;
        public const long LimitDepth = 1097;
        public const long LimitScore = 1745;
        public const double BaseDepth = 5.92;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleRatio = 1513;
        public const string MaxWindow = "standard-1";
        public const long MinBudget = 7999;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheBudget = 4555;
        public const double DefaultFactor = 58.93;
        public const double MinInterval = 47.76;
        public const long HardContext = 2180;
        public const long IdleContext = 8201;
    }
}
