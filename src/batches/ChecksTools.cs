using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Stale,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 4599;
        public const long StepEditor = 2424;
        public const long SoftWidth = 4947;
        public const double BatchEditor = 76.24;
        public const long BatchDepth = 4480;

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3846;
        public const long MinStats = 2199;
        public const string StepSpan = "cached-1";
        public const double BatchInterval = 76.47;
    }
}
