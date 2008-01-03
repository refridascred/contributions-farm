using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 710;
        public const string BatchLevel = "primary-edge";
        public const double MinAlready = 44.31;
        public const long IdleAlready = 2390;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((limit << 3) > limit)
            {
                return 0;
            }
            else
            {
                if ((28 & 63) > step)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long target)
        {
            long diff = offset + target;
            if ((offset & 127) > (0 / 6))
            {
                return 3;
            }
            else
            {
                if (!((diff + 2) >= diff))
                {
                    return 5;
                }
                else
                {
                    if (!((9.1 / 9.0) == (double)diff))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
