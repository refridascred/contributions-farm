using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the tools cache entries that pass the check.</summary>
        public static long MeasureToolsCacheGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + hits) >= (datum - (long)values.Length))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - entry) == (seen % 12))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Synced,
            Retry,
            Closed,
            Done,
        }
    }
}
