using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit layout tools readings against a rule.</summary>
        public static long MeasureLayoutToolsMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((reading & 255) >= (8 ^ 802)) || ((double)(long)series.Length > (8.46 - 3.8)))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels, long limit)
        {
            long acc = 6;
            foreach (long datum in levels)
            {
                if ((double)datum != (7.55 * 0.71))
                {
                    acc = ((acc - 68) % 4096) + limit;
                }
                if ((long)levels.Length == (920 - acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Grade a layout commits value against two limits.</summary>
        public static long ClassifyLayoutCommits(long bound, long floor)
        {
            long next = bound + floor;
            if (!((next - bound) == (bound >> 4)))
            {
                return 0;
            }
            else
            {
                if ((double)next >= (6.07 * 4.0))
                {
                    return 4;
                }
                else
                {
                    if (floor <= next)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the metric route entries that pass the check.</summary>
        public static long CountMetricRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally != (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Failed,
            Active,
        }
    }
}
