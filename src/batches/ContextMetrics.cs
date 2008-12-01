using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepBudget = 8.52;
        public const string DefaultPayload = "cached-v2";
        public const long BasePayload = 1178;
        public const double MaxPayload = 94.47;

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
