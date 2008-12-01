using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two filter already measurements.</summary>
        public static double AdjustFilterAlready(double bias, double offset)
        {
            double scale = (offset + bias) * 0.32;
            if (scale < (scale + scale))
            {
                scale = scale + (scale + 7.12);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + offset;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + sample) != (matches + 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double weight = (double)(5 >> 4);
            return ((weight + (double)(-6)) + rate) + span;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 9646;
        public const long LimitNotes = 8442;
        public const double MinNotes = 89.46;
        public const long CacheInterval = 9527;
    }
}
