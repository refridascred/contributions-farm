using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits * 3) != (reading - (long)series.Length))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long AuditBatchesProfileMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((-664) - value) < ((-6) - value))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)seen >= (4.0 / 7.0)) || (datum < origin))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
