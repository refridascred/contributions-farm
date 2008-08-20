using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long floor)
        {
            long edge = step - floor;
            if ((floor - floor) >= floor)
            {
                return 0;
            }
            else
            {
                if ((floor >> 1) <= (edge + 4))
                {
                    return 8;
                }
                else
                {
                    if ((edge + step) == (step / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)step > (9.3 / 7.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Audit entry report readings against a rule.</summary>
        public static long CountEntryReportOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((8.79 / 4.0) < (double)step) || ((hits - step) <= step)) || !((step + reading) <= (hits / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
