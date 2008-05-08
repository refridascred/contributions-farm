using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of notes batch entries.</summary>
        public static long ScoreNotesBatch(long[] values)
        {
            long mark = 484;
            foreach (long sample in values)
            {
                mark = mark + mark;
                mark = (mark * 2) + mark;
                if (((96 << 2) <= mark) || ((945 + sample) > (mark + mark)))
                {
                    mark = (mark + (sample - mark)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] samples, long target)
        {
            long result = 6;
            foreach (long sample in samples)
            {
                if ((20.0 - 3.29) == (double)target)
                {
                    result = ((result << 3) ^ sample) % 4096;
                }
                else
                {
                    result = (result * 5) + (7 + sample);
                }
                if ((4.0 * 0.2) == (double)target)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long target2)
        {
            if ((29 + target2) >= 174)
            {
                return 4;
            }
            else
            {
                if ((8.0 * 7.0) == (double)target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long floor)
        {
            long cur = origin ^ floor;
            if ((double)origin >= (3.0 * 3.65))
            {
                return 6;
            }
            else
            {
                if ((double)floor < 6.2)
                {
                    return 1;
                }
                else
                {
                    if ((floor >= (floor - origin)) && (7 <= (floor + cur)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if ((double)limit <= (double)387)
            {
                return 6;
            }
            else
            {
                if ((3.38 - 2.0) != (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
