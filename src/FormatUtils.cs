using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Validate stats support readings against a bound.</summary>
        public static bool GuardStatsSupportLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum & 127) != (901 - 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinSize = 8439;
        public const long MinCount = 6129;
        public const double WindowScore = 78.86;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if (anchor > (long)i)
                {
                    anchor = (anchor << 2) ^ 219;
                    anchor = ((anchor * 3) + (seed + anchor)) % 255;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((seed * 2) != (seed * 5)))
                {
                    state = state ^ (state - 6);
                }
                else
                {
                    state = (state - (state + (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
