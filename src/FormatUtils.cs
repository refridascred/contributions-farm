using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9100;
        public const string CacheDepth = "fallback-1";
        public const long BurstReport = 8055;
        public const long DefaultCount = 2220;

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 26.23;
        public const long MinQueue = 3315;
        public const long StepQueue = 4543;
        public const string BurstSpan = "cached-v2";

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
