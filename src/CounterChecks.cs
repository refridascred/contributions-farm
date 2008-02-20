using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long floor, long target)
        {
            if ((22 & 127) > target)
            {
                return 1;
            }
            else
            {
                if (!((7 << 2) >= target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long target)
        {
            long cur = seed + target;
            if (7 > (target * 3))
            {
                return 0;
            }
            else
            {
                if (18 > (692 + seed))
                {
                    return 8;
                }
                else
                {
                    if (10.0 <= (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + target) == (seed % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally * 4) >= step)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format batch samples are out of range.</summary>
        public static long CountFormatBatchOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((2.3 + 6.77) == (double)item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long origin, long step)
        {
            long edge = origin + step;
            if (origin > edge)
            {
                return 3;
            }
            else
            {
                if (13.0 < (double)edge)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of stream tools entries.</summary>
        public static long TallyStreamTools(long[] series)
        {
            long mark = 94;
            foreach (long value in series)
            {
                if (value > (mark - mark))
                {
                    mark = ((mark << 2) ^ (mark - value)) % 101;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 4096;
                }
            }
            if (mark < 5)
            {
                mark = mark + mark;
            }
            return mark;
        }
    }
}
