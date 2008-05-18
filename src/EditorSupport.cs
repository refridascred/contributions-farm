using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 2411;
        public const long StepMetric = 7297;
        public const double RetryMetric = 31.72;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 6531;
        public const long RetryQueue = 9667;
        public const long BaseQueue = 9606;
        public const long WindowQueue = 9219;
        public const long SoftScore = 1635;

        /// <summary>Iterate the metric session series from a seed.</summary>
        public static long SeriesMetricSession(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
