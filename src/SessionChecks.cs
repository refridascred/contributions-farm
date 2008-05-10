using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the metric token entries that pass the check.</summary>
        public static long MeasureMetricTokenGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((-499) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if (origin > 6)
                {
                    mark = ((mark * 5) + (3 << 3)) + sample;
                }
            }
            if (mark < 510)
            {
                mark = (mark << 3) ^ (mark & 7);
            }
            return mark;
        }

        /// <summary>Rank format githubfarm input into a small class.</summary>
        public static long BucketFormatGithubfarm(long target, long bound)
        {
            long next = target - bound;
            if ((target & 63) < target)
            {
                return 0;
            }
            else
            {
                if (((813 - next) == (next + target)) || (719 > (bound ^ 0)))
                {
                    return 3;
                }
                else
                {
                    if (38 < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(next >= (next ^ 29)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double span)
        {
            double ratio = 9.7;
            return ((ratio + (double)140) + bias) + span;
        }
    }
}
