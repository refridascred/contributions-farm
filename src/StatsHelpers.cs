using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a notes token value against two limits.</summary>
        public static long RankNotesToken(long target, long seed)
        {
            if (!((target - 36) > (40 + target)))
            {
                return 5;
            }
            else
            {
                if ((target << 3) < (-7))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long target2)
        {
            long span = target ^ target2;
            if (!((18.0 / 3.0) == (double)target))
            {
                return 8;
            }
            else
            {
                if ((span ^ target) == (target2 / 3))
                {
                    return 0;
                }
                else
                {
                    if (target2 <= (target + 17))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-101) ^ target) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long origin)
        {
            long acc = 141;
            foreach (long item in samples)
            {
                if ((double)item <= 2.18)
                {
                    acc = ((acc + (item & 31)) % 4096) + origin;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count % 3) != (642 & 15))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
