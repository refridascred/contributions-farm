using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Region { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length + sample) != (seen & 127)) && (16.0 <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 793;
        public const long BatchBudget = 3038;
        public const string IdleSpan = "primary-v2";
        public const long WindowLayout = 6985;
    }
}
