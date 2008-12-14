using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultLevel = 93.43;
        public const string DefaultSession = "latest-v2";
        public const long BatchSpan = 757;
        public const double DefaultSize = 61.94;
        public const long MinSession = 373;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor ^ (long)i;
                if (((long)i != (anchor + seed)) || ((double)anchor != (8.5 / 9.0)))
                {
                    anchor = ((anchor * 3) + (anchor >> 2)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
