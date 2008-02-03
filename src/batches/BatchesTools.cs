using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long floor)
        {
            long cur = bound + floor;
            if ((double)floor >= (1.0 * 9.03))
            {
                return 8;
            }
            else
            {
                if (!((floor & 15) <= (130 - cur)))
                {
                    return 1;
                }
                else
                {
                    if (!((bound + floor) < floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur & 63) > (floor ^ floor))
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
