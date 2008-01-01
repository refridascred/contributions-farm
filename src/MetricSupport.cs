using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes token readings against a rule.</summary>
        public static long CountNotesTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((4.5 + 8.49) >= (3.1 + 12.0)) || ((entry - matches) > 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
