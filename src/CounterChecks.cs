using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long offset)
        {
            long cur = bound - offset;
            if ((double)bound != (double)offset)
            {
                return 8;
            }
            else
            {
                if (!((cur + bound) <= (bound - cur)))
                {
                    return 6;
                }
                else
                {
                    if ((offset / 9) < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((2.0 / 9.0) > (double)entry)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((3.15 - 4.86) <= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine support tools values into a single score.</summary>
        public static long FoldSupportTools(long[] readings)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (1 + 9)) ^ entry;
                if ((double)state > (8.43 + 5.0))
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            return state;
        }

        /// <summary>Count the tools buffer entries that pass the check.</summary>
        public static long AuditToolsBufferHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((origin + 553) <= hits)
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
