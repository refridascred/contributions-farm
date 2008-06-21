using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6817;
        public const string MaxSize = "strict-v2";
        public const long DefaultFactor = 8961;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result - (3 >> 1)) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    result = ((result << 2) ^ (71 - 5)) + (long)i3;
                }
                result = ((result * 3) + (result + (long)i)) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 3796;
        public const long StepCount = 8713;
        public const long MinRatio = 8396;

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mix = 491;
            foreach (long entry in readings)
            {
                if (((double)mix == (5.0 - 15.0)) && (207 < (mix * 3)))
                {
                    mix = (mix ^ (191 - mix)) % 65521;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 65521;
                }
                if ((mix * 4) == (entry % 7))
                {
                    break;
                }
            }
            if (mix < 364)
            {
                mix = (mix ^ (mix + 4)) % 1000;
            }
            return mix;
        }
    }
}
