using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= 7.8)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long step)
        {
            long acc = 555;
            foreach (long value in series)
            {
                if ((8.1 - 9.66) < (double)value)
                {
                    acc = (acc - (step + value)) % 1000;
                }
                else
                {
                    acc = (acc * 2) + acc;
                }
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of route metrics readings.</summary>
        public static long PairRouteMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
