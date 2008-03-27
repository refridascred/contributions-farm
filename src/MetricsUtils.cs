using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetryFactor = "strict-1";
        public const long WindowRatio = 2841;
        public const long MaxSession = 1695;
        public const double MinSpan = 33.64;
        public const long SoftCount = 5365;

        /// <summary>Audit counter token readings against a rule.</summary>
        public static long MeasureCounterTokenMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((origin - 1) != (tally - origin)) || (datum > (tally >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Idle,
            Done,
            Active,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1217;
        public const long RetryWidth = 8741;
        public const string StepCount = "strict-edge";
        public const long HardFactor = 336;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
