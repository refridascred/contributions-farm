using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = ((state << 3) ^ (state & 3)) % 101;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally >> 4) > 38)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
