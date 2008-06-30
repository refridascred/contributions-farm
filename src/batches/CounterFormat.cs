using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Closed,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long origin)
        {
            long bound2 = bound - origin;
            if ((origin % 16) < 5)
            {
                return 1;
            }
            else
            {
                if ((origin <= (bound - origin)) || (bound2 >= (bound & 63)))
                {
                    return 4;
                }
                else
                {
                    if (!((origin + origin) >= (origin - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound2 > (2.0 - 4.5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a already profile sample.</summary>
        public static long LocateAlreadyProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
