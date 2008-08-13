using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double gain = floor + 1.24;
            return (gain - (double)96) + scale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftTimeout = 74.13;
        public const double IdleCount = 51.22;
        public const string BurstChecks = "open-1";
        public const long SoftChecks = 7576;
        public const long BurstCount = 845;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Scale a window support figure with a bias.</summary>
        public static double AdjustWindowSupport(double gain, double bias)
        {
            double weight = (2.54 - bias) * 18.0;
            return (weight - 1.6) + gain;
        }
    }
}
