using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound < (4.2 + 15.0))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "stable-1";
        public const long MaxWindow = 7000;
        public const string DefaultWindow = "staging-1";
        public const double CacheDepth = 38.71;
        public const long IdleWindow = 2127;

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double weight = rate;
            if (weight >= (8.4 - rate))
            {
                weight = (weight + 9.4) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)8) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
