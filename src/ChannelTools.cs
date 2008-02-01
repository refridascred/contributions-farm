using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a stats channel pair into a bucket.</summary>
        public static long BucketStatsChannel(long origin, long limit)
        {
            long lane = origin ^ limit;
            if (origin > (origin >> 1))
            {
                return 0;
            }
            else
            {
                if ((origin & 127) == (lane + lane))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ lane) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane - (-792)) <= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long bound, long limit)
        {
            long cur = bound + limit;
            if (((13.0 / 6.0) >= (double)cur) || ((13.0 * 5.0) != (double)limit))
            {
                return 5;
            }
            else
            {
                if (((cur << 1) > (bound % 60)) || ((959 ^ bound) == (cur / 5)))
                {
                    return 2;
                }
                else
                {
                    if ((cur % 16) <= (cur - 761))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 62.64;
        public const string MinToken = "standard-edge";
        public const long HardToken = 4023;
        public const long WindowDepth = 277;
    }
}
