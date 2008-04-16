using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((9.8 / 7.0) >= (double)seen) && (seed > seen)) && ((long)items.Length > (datum % 16)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload support pair into a bucket.</summary>
        public static long RankPayloadSupport(long step, long origin)
        {
            if ((9.93 + 5.81) < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((step << 3) > step)
                {
                    return 4;
                }
                else
                {
                    if ((origin & 63) < (origin % 12))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + origin) <= (step + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((origin - origin) <= origin)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long seed)
        {
            long next = limit ^ seed;
            if (((5 - limit) == (59 - next)) && ((2.11 + 7.71) <= (double)next))
            {
                return 3;
            }
            else
            {
                if ((seed >> 1) >= (seed ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
