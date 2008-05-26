using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of filter contributi readings.</summary>
        public static long CombineFilterContributi(long[] data)
        {
            long result = 10;
            foreach (long sample in data)
            {
                if ((result + sample) < (result % 10))
                {
                    result = ((result << 3) ^ (long)data.Length) % 101;
                }
            }
            return result;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long origin, long bound)
        {
            long cur = origin - bound;
            if (((5.15 * 2.23) >= (double)origin) || (53 >= (origin ^ cur)))
            {
                return 6;
            }
            else
            {
                if ((847 / 4) > origin)
                {
                    return 2;
                }
                else
                {
                    if (origin > (bound << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((cur + origin) <= (bound << 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Idle,
            Retry,
            Paused,
        }
    }
}
