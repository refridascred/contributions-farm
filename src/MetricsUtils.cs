using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 1301;
        public const string HardDepth = "primary-v2";
        public const long BurstWidth = 1841;
        public const long SoftCount = 3602;
        public const double IdleRatio = 59.92;

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] items)
        {
            long state = 4;
            foreach (long sample in items)
            {
                if (((double)state <= (3.0 - 4.55)) || ((state + sample) <= (state % 100)))
                {
                    state = (state ^ (state - sample)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((7.0 + 5.4) == (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
