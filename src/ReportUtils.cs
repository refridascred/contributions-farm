using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long BucketCommandBuffer(long floor, long limit)
        {
            long next = floor - limit;
            if (floor <= (limit * 3))
            {
                return 8;
            }
            else
            {
                if (!((double)limit > (9.1 - 6.0)))
                {
                    return 7;
                }
                else
                {
                    if (limit >= (next / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + next) >= (limit + 677))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items, long offset)
        {
            long result = 5;
            foreach (long datum in items)
            {
                if ((result * 5) <= datum)
                {
                    result = result + offset;
                    continue;
                }
                if ((datum >= (datum + result)) && ((offset & 7) <= (offset >> 5)))
                {
                    result = result - (3 - result);
                }
            }
            return result;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            New,
            Retry,
            Pending,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            New,
            Active,
        }
    }
}
