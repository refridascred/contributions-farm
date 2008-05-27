using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long bound, long target)
        {
            long offset = bound ^ target;
            if (!(target > (bound >> 3)))
            {
                return 4;
            }
            else
            {
                if ((0.6 / 6.0) >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset % 100) > (62 - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target == (15.0 / 7.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double scale = 3.0;
            if (scale >= (double)3)
            {
                scale = (scale - (5.2 + bias2)) + bias;
            }
            return scale + scale;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long offset, long floor)
        {
            if ((offset % 12) > floor)
            {
                return 8;
            }
            else
            {
                if ((offset > (offset + offset)) && ((floor + 894) <= offset))
                {
                    return 4;
                }
                else
                {
                    if ((3 + floor) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Dropped,
            Closed,
            New,
            Synced,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long mark = 67;
            foreach (long reading in levels)
            {
                mark = mark + (reading + mark);
                if ((double)mark >= (7.09 / 7.0))
                {
                    mark = (mark + (9 % 5)) % 1000;
                }
            }
            if (mark < 40)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }
    }
}
