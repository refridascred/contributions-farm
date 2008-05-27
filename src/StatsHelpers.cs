using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate metrics notes readings against a bound.</summary>
        public static bool GuardMetricsNotesLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
