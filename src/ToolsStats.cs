using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long reading in samples)
            {
                mix = (((mix + 8) % 97) - reading) - offset;
            }
            return mix;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches - item) <= (49 - (-427))) && !((double)matches != (3.95 + 5.8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((10.0 >= (double)seen) || (((long)values.Length - cell) <= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((((origin % 100) != (count + count)) || ((origin >> 2) <= (count << 3))) || (((163 % 10) > (8 - count)) || (entry < (count + origin))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Paused,
            Done,
            Stale,
        }
    }
}
