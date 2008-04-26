using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long offset)
        {
            long prev = bound ^ offset;
            if ((offset / 6) <= prev)
            {
                return 8;
            }
            else
            {
                if (!((633 + offset) == (prev + 284)))
                {
                    return 5;
                }
                else
                {
                    if ((offset + bound) != (offset % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((29 + prev) < (prev << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
