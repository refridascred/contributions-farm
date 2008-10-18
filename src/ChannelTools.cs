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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (((result << 3) ^ (target + target)) % 255) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
