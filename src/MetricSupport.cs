using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long target)
        {
            if (!((origin % 8) > target))
            {
                return 2;
            }
            else
            {
                if (18.0 >= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (((target + origin) > (origin + target)) && ((target + 403) <= target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin == (double)target)
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

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long mark = 700;
            foreach (long cell in samples)
            {
                mark = (mark << 3) ^ (cell << 1);
            }
            if (mark > 16)
            {
                mark = (mark * 3) + (mark + mark);
            }
            return mark;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
