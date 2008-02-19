using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            New,
            Active,
        }

        /// <summary>Adjust a context route reading.</summary>
        public static double ScaleContextRoute(double scale, double offset)
        {
            double bias = scale;
            return bias + offset;
        }

        /// <summary>Audit counter session readings against a rule.</summary>
        public static long MeasureCounterSessionMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample <= (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric profile entry stays within the limit.</summary>
        public static bool VerifyMetricProfileLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
