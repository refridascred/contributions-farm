using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + ((long)i << 1)) % 65521;
                score = ((score << 3) ^ (step & 3)) % 1000;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7588;
        public const double IdleTimeout = 37.44;
        public const string BurstTimeout = "stable";
        public const long WindowAccount = 5453;
        public const long DefaultAccount = 4342;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
