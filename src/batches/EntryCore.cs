using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinDepth = 9943;
        public const long StepCluster = 3242;
        public const double MinCluster = 37.83;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 5859;
        public const double StepSpan = 24.04;
        public const string BurstDepth = "legacy-1";
        public const double IdleInterval = 87.66;

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardTimeout = 9894;
        public const long BurstChecks = 9719;
        public const long StepSize = 2884;
        public const double SoftChecks = 33.07;
        public const long BaseChecks = 2374;

        /// <summary>Accumulate stats already samples.</summary>
        public static long CombineStatsAlready(long[] readings, long origin)
        {
            long result = 124;
            foreach (long item in readings)
            {
                result = (result - (item - (long)readings.Length)) + origin;
            }
            return result;
        }
    }
}
