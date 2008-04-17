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

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Label { get; set; } = "";
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples)
        {
            long score = 63;
            foreach (long sample in samples)
            {
                score = (score * 2) + (score ^ score);
                if ((sample + 188) != (68 - sample))
                {
                    break;
                }
            }
            return score;
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

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Paused,
            Dropped,
            Retry,
            New,
        }
    }
}
