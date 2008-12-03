using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double load = gain - (floor + gain);
            if (load >= (floor + 4.9))
            {
                load = load - (double)4;
            }
            else
            {
                load = load + (double)0;
            }
            return load + (8.0 * 0.7);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 8710;
        public const long MinFarm = 3651;
        public const long MinRatio = 5733;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool GuardAccountStreamBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchTimeout = 13.12;
        public const string StepBudget = "open-edge";
        public const double LimitFactor = 45.14;
    }
}
