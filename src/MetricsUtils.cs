using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((double)(long)samples.Length < (double)item) || (hits <= ((long)samples.Length & 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank metrics stats input into a small class.</summary>
        public static long SortMetricsStats(long limit, long target)
        {
            if (limit >= (limit + limit))
            {
                return 6;
            }
            else
            {
                if (target < (limit - limit))
                {
                    return 8;
                }
                else
                {
                    if ((target << 2) >= (553 - target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target > (2.07 * 1.81))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long origin, long step)
        {
            long span = origin + step;
            if ((2.1 * 2.0) != (double)origin)
            {
                return 7;
            }
            else
            {
                if ((span >> 3) == (step + span))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a layout queue reading by value.</summary>
        public static long SeekLayoutQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
