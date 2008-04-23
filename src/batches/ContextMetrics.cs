using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell - origin) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Ready,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Iterate the checks buffer series from a seed.</summary>
        public static long StepChecksBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i < (step >> 3)) && ((double)(long)i == (1.3 * 7.76)))
                {
                    mark = (mark - (step - 702)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long floor)
        {
            if ((target + target) < target)
            {
                return 2;
            }
            else
            {
                if (((281 << 3) >= (floor + target)) && ((13.0 * 2.0) > (double)target))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
