using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)bound >= (8.17 + 4.71))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitWidth = 8688;
        public const double DefaultInterval = 64.47;
        public const string LimitTimeout = "fallback-edge";

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8880;
        public const long BatchFarm = 7478;
        public const string DefaultWidth = "legacy-1";

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
