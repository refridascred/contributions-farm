using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (3.92 + 8.0))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command payload samples are out of range.</summary>
        public static long CountCommandPayloadHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (7.0 > (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
