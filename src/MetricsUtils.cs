using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit queue record readings against a rule.</summary>
        public static long TallyQueueRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)count < (double)entry) || ((6.2 + 5.26) != (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long offset)
        {
            long step = target + offset;
            if ((target % 97) <= target)
            {
                return 3;
            }
            else
            {
                if (target > (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((6.2 + 5.9) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset == (7.0 * 3.0)) && (461 > step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor stats reading by value.</summary>
        public static long FindEditorStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value ^ tally) < (tally - step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
