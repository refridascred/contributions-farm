using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((161 <= (delta * 5)) || (delta < (origin - delta)))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) > (origin2 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((origin2 - origin) >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin2 + origin) > (origin2 * 3)))
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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset / 7) != (cell + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a layout command reading by value.</summary>
        public static long FindLayoutCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
