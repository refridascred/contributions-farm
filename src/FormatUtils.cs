using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (944 <= (long)readings.Length)
                {
                    tally = ((tally + 3) + sample) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell % 16) < (count + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long origin, long limit)
        {
            if (!((origin - limit) == (origin / 9)))
            {
                return 3;
            }
            else
            {
                if ((0 ^ limit) <= (limit & 1))
                {
                    return 2;
                }
                else
                {
                    if (9 <= (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long seed)
        {
            if ((step - seed) < (seed << 2))
            {
                return 0;
            }
            else
            {
                if ((seed & 1) > (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if ((13.0 - 4.92) < (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (seed ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(reading > (514 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
