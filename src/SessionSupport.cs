using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long origin)
        {
            if ((double)origin < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((2.0 * 5.79) < (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (!((double)origin == (0.2 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin << 2) < (offset + 167)) && ((6.8 - 2.7) >= (double)offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a account notes sample.</summary>
        public static long LocateAccountNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
