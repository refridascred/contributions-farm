using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) < entry)
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long MeasureEditorBatchesHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((15.0 * 2.6) == (double)floor)
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxCount = 21.67;
        public const double LimitSchema = 54.46;
        public const long DefaultSchema = 1368;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
