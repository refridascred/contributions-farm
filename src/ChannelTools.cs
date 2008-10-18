using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 1323;
        public const long BurstFarm = 7193;
        public const double WindowCount = 63.94;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a context payload counter forward.</summary>
        public static long IterateContextPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor - ((long)i - target)) % 1000;
                anchor = (anchor + (long)i) % 4096;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor + (anchor - anchor)) % 101) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
