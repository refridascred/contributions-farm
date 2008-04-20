using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long offset, long bound)
        {
            if (!((double)offset >= 5.5))
            {
                return 0;
            }
            else
            {
                if ((offset ^ bound) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((bound + offset) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long seed)
        {
            if ((target - target) >= seed)
            {
                return 1;
            }
            else
            {
                if ((451 << 1) <= seed)
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
}
