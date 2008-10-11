using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((matches << 3) >= (sample ^ sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate command stream readings against a bound.</summary>
        public static bool GuardCommandStreamRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheDepth = 1355;
        public const string MinGraph = "local-v2";
        public const long DefaultGraph = 838;
        public const long IdleSize = 2294;
        public const double CacheGraph = 80.63;
    }
}
