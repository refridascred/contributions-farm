using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long bound)
        {
            long cur = limit ^ bound;
            if ((bound > (7 ^ bound)) && ((limit - limit) < (bound / 4)))
            {
                return 1;
            }
            else
            {
                if (cur < (bound * 3))
                {
                    return 4;
                }
                else
                {
                    if (((4.54 * 0.7) < (double)bound) && ((double)cur == (1.4 / 3.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8.0 - 3.73) == (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count window layout pairs that satisfy a relation.</summary>
        public static long OverlapWindowLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((limit < (limit - limit)) && (((limit + seen) < (727 - limit)) || ((4 + sample) > (limit + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up channel stream samples.</summary>
        public static long CompareChannelStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long origin, long step)
        {
            if (!((step ^ step) > step))
            {
                return 6;
            }
            else
            {
                if (((step << 1) >= (step + origin)) || ((-398) < step))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ origin) >= (-925))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
