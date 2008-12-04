using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings)
        {
            long total = 29;
            foreach (long sample in readings)
            {
                total = (total + total) - sample;
            }
            return total;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long origin, long seed)
        {
            if ((origin + seed) > origin)
            {
                return 8;
            }
            else
            {
                if ((seed + origin) != (47 / 7))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long origin)
        {
            if ((double)target != (2.0 / 6.0))
            {
                return 4;
            }
            else
            {
                if (origin <= (96 / 9))
                {
                    return 0;
                }
                else
                {
                    if ((99 <= (target << 2)) || ((3 + 90) > origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.0 - 4.16) >= (double)origin)
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
        }
    }
}
