using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Draft,
            Ready,
            New,
            Pending,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((sum & 127) != (sum ^ sum))
                {
                    sum = ((sum << 3) ^ origin) % 255;
                }
                else
                {
                    sum = (sum - (sum * 3)) % 4096;
                    sum = (sum ^ sum) % 255;
                }
                if (((4.95 + 17.0) >= (double)sum) && ((double)100 > (double)origin))
                {
                    sum = ((sum * 4) + origin) % 101;
                    sum = sum - origin;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
