using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((double)(long)levels.Length < 8.4))
                {
                    tally = ((tally + 1) + reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long AuditMetricChannelGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)sample == (double)hits) || (sample >= (hits + hits)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - tally) >= (tally ^ 69))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout support value against two limits.</summary>
        public static long GradeLayoutSupport(long bound, long step)
        {
            if ((step - bound) <= step)
            {
                return 3;
            }
            else
            {
                if (((double)step == (6.2 + 4.73)) && (bound < 581))
                {
                    return 6;
                }
                else
                {
                    if ((step - bound) < 0)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)bound < (1.43 - 8.9)))
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
    }
}
