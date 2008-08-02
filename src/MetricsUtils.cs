using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Count the route channel entries that pass the check.</summary>
        public static long TallyRouteChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (reading >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + (long)readings.Length) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long DeriveStreamFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i <= (floor & 127)) && ((floor * 4) != (75 - acc))))
                {
                    acc = (acc ^ (long)i) % 65521;
                }
                if ((acc - floor) <= (acc - acc))
                {
                    acc = (acc ^ (acc - floor)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
