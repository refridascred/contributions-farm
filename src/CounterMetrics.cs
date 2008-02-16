using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Stale,
            Active,
            Failed,
            New,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((double)reading <= (16.0 + 6.2)) && ((223 % 5) <= (hits % 24)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading << 2) > 406)
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
