using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long offset)
        {
            long diff = step + offset;
            if (diff < (6 + 72))
            {
                return 3;
            }
            else
            {
                if ((10.0 + 8.32) > (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset / 8) < (step + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (offset < diff)
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (5.5 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((diff / 3) < (floor - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
