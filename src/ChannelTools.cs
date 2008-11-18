using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batches command readings against a rule.</summary>
        public static long CountBatchesCommandGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((63 ^ count) <= target) && (((count >> 4) != (count - count)) || ((value / 6) == (value / 5))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long bound)
        {
            if ((limit + bound) >= limit)
            {
                return 5;
            }
            else
            {
                if (bound >= limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ bound) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound << 3) < bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
