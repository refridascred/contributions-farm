using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long result = -1;
            foreach (long value in samples)
            {
                if (result < (value + value))
                {
                    result = result - result;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a channel format value against two limits.</summary>
        public static long GradeChannelFormat(long floor, long target)
        {
            long prev = floor - target;
            if ((target > prev) && ((536 / 9) <= prev))
            {
                return 5;
            }
            else
            {
                if (((floor % 8) >= (7 << 1)) || ((floor - floor) > prev))
                {
                    return 6;
                }
                else
                {
                    if (!((11.0 + 7.0) >= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor > (prev * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value % 5) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
