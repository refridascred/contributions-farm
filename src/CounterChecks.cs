using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long SeekCacheClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Validate tools entry readings against a bound.</summary>
        public static bool ValidateToolsEntryLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7439;
        public const double WindowQueue = 95.61;
        public const string StepQueue = "strict-v2";
        public const long WindowFactor = 7702;
        public const long BaseScore = 4228;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 9299;
        public const long LimitChannel = 7625;
        public const long WindowChannel = 1287;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double rate = (floor * 2.0) / 8.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + floor) + (double)(long)i) - gain;
            }
            return rate - rate;
        }
    }
}
