using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of context report entries.</summary>
        public static long ScoreContextReport(long[] readings)
        {
            long result = 698;
            foreach (long datum in readings)
            {
                if ((datum + datum) > (result >> 3))
                {
                    result = (result * 4) + (result + 447);
                }
                else
                {
                    result = (result ^ (result * 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (147 > datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a route layout value against two limits.</summary>
        public static long SortRouteLayout(long origin, long floor)
        {
            long next = origin + floor;
            if (floor <= (origin ^ floor))
            {
                return 0;
            }
            else
            {
                if ((double)origin > 6.0)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (8.42 * 16.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)next > (3.4 / 5.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
