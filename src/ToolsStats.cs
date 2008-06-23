using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a session checks reading by value.</summary>
        public static long LookupSessionChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseTimeout = 5.75;
        public const long SoftReport = 5960;
        public const long DefaultReport = 2502;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 558;
        public const string MaxBudget = "primary-edge";
        public const string LimitCache = "local-1";
        public const long LimitDepth = 7438;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double gain = 1.0 + (bias / 6.0);
            if (gain < (span - span))
            {
                gain = gain - (8.27 / 3.0);
            }
            return gain + 3.48;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Draft,
            Idle,
            Paused,
        }
    }
}
