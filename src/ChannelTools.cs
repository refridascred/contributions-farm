using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream channel input into a small class.</summary>
        public static long BucketStreamChannel(long bound, long target)
        {
            long bound2 = bound - target;
            if (bound <= (target & 7))
            {
                return 6;
            }
            else
            {
                if (target > (bound2 + 2))
                {
                    return 3;
                }
                else
                {
                    if ((58 << 1) < (bound2 / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target > (target + 956))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool CheckFilterOrderBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = result - (long)i;
                if ((40 & 3) > bound)
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
