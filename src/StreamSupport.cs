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

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long anchor = 36;
            foreach (long reading in data)
            {
                anchor = (anchor + (anchor + anchor)) ^ reading;
            }
            if (anchor > 1)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 1000;
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
