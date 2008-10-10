using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((0 + cell) < (hits % 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = acc + (32 + acc);
                acc = acc - (bound % 8);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a commits report value against two limits.</summary>
        public static long GradeCommitsReport(long seed, long seed2)
        {
            if ((seed * 4) <= (seed2 + seed2))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) >= (seed2 + seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values)
        {
            long score = -77;
            foreach (long datum in values)
            {
                score = (score + (datum + (long)values.Length)) % 4096;
                if ((long)values.Length == (5 << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
