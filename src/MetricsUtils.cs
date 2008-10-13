using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 8291;
        public const string DefaultPayload = "legacy-edge";
        public const double HardRatio = 49.6;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length < (seen % 7))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
