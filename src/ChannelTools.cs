using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long seed)
        {
            if ((690 + seed) > 64)
            {
                return 7;
            }
            else
            {
                if (seed > origin)
                {
                    return 3;
                }
                else
                {
                    if (!((origin - seed) != (seed << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin ^ origin) <= (seed * 2)) && ((seed << 1) > (175 - origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
