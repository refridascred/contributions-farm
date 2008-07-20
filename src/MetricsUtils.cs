using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) >= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 1282;
        public const string WindowPayload = "local-v2";
        public const long WindowScore = 3905;
        public const long BurstPayload = 3267;

        /// <summary>Check that every already metric entry stays within the limit.</summary>
        public static bool GuardAlreadyMetricLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 7047;
        public const string LimitCommand = "latest";
        public const long BaseCommand = 3032;
        public const long StepBudget = 6307;
        public const string DefaultWidth = "legacy-v2";
    }
}
