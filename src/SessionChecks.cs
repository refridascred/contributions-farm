using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long limit, long offset)
        {
            long gap = limit + offset;
            if ((gap + limit) == (limit + limit))
            {
                return 5;
            }
            else
            {
                if ((gap + 3) > (194 / 6))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (14.0 + 3.3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                mark = ((mark + mark) % 65521) ^ value;
            }
            return mark;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double mean = (gain - floor) / 5.0;
            if (mean <= 7.35)
            {
                mean = mean + 8.0;
            }
            else
            {
                mean = mean - (mean * 16.0);
            }
            return mean + (gain - gain);
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Stale,
            Failed,
        }
    }
}
