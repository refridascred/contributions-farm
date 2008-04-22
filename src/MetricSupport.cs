using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long floor)
        {
            if ((floor >> 2) > (830 << 2))
            {
                return 3;
            }
            else
            {
                if (794 < (origin >> 3))
                {
                    return 5;
                }
                else
                {
                    if (((4.8 * 2.9) < (double)origin) && ((origin / 4) < floor))
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

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long floor)
        {
            if ((floor >> 5) > (floor - 593))
            {
                return 2;
            }
            else
            {
                if (((5.15 * 14.0) < (double)bound) && ((double)floor <= (11.0 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
