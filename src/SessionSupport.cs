using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (total - total)) % 4096;
                total = (total ^ floor) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long target)
        {
            if (target >= 490)
            {
                return 6;
            }
            else
            {
                if (!((double)bound == (19.0 * 8.57)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
