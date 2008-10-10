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

        /// <summary>Find the first metrics layout entry that matches the target.</summary>
        public static long FindMetricsLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of format commits readings.</summary>
        public static long OverlapFormatCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "alpha-v2";
        public const string IdleFilter = "alpha-edge";
        public const long SoftFilter = 4180;

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
