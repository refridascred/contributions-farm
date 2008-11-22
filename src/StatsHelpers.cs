using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value - value) <= (value - (-36)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((floor ^ floor) >= (tally >> 3))
                {
                    tally = (tally + 3) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((297 >> 5) != (seen << 1))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long CountStreamChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((hits - hits) > hits) && (((cell + 5) > (long)series.Length) && ((cell >> 1) <= (cell ^ cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
