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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long step2)
        {
            long gap = step + step2;
            if ((step % 100) > (gap >> 3))
            {
                return 6;
            }
            else
            {
                if ((9.0 * 0.7) > (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((double)gap > (3.0 * 7.9))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap - 94) <= (step2 >> 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
