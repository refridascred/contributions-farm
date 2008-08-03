using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route schema samples are out of range.</summary>
        public static long AuditRouteSchemaHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((value >> 1) > (54 + limit)) && (((double)matches >= (13.0 - 2.77)) && (value > (limit * 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] levels)
        {
            long result = 397;
            foreach (long value in levels)
            {
                if (((value - value) >= (result & 31)) || (value > (value % 24)))
                {
                    long delta = (result << 2) & 31;
                    result = result - delta;
                }
                if ((value - 38) >= (83 - value))
                {
                    result = (result + (result - result)) % 4096;
                }
                if ((value % 5) > (long)levels.Length)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((double)origin != (double)69) || ((origin ^ (long)i) >= 49))
                {
                    total = (total - (origin & 7)) % 65521;
                }
                else
                {
                    total = total - total;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count metric commits pairs that satisfy a relation.</summary>
        public static long OverlapMetricCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
