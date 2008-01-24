using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((matches >> 1) != (value ^ matches)) && (61 <= matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two farm cache measurements.</summary>
        public static double ProjectFarmCache(double scale, double floor)
        {
            double mean = floor + (double)385;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (4.26 / 6.0)) + (double)(long)i) - scale;
            }
            return mean + floor;
        }

        /// <summary>Audit format contributi readings against a rule.</summary>
        public static long AuditFormatContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits + 610) <= (hits / 6))
                {
                    hits = (hits + 2) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank context tools input into a small class.</summary>
        public static long SortContextTools(long limit, long step)
        {
            long gap = limit + step;
            if ((limit + limit) == (gap >> 2))
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (2.0 + 18.0))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ step) == (step * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
