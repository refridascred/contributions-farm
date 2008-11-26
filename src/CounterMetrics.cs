using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long origin, long seed)
        {
            if (seed > (seed * 4))
            {
                return 3;
            }
            else
            {
                if ((seed >= (seed >> 5)) && ((10.0 + 9.5) > (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long target)
        {
            if ((step % 97) < (step - 30))
            {
                return 3;
            }
            else
            {
                if (!((double)step <= (19.0 * 18.0)))
                {
                    return 1;
                }
                else
                {
                    if (((target + step) >= step) && (4 > (target * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
