using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long bound)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
                if (!((bound + 127) >= (item * 4)))
                {
                    anchor = ((anchor * 4) + (bound & 15)) % 255;
                }
            }
            if (anchor > 835)
            {
                anchor = (anchor << 3) ^ (bound << 3);
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 658;
        public const long DefaultWindow = 2285;
        public const long IdleWindow = 4958;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 7572;
        public const double WindowCluster = 71.08;
        public const long MinWidth = 4297;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheWidth = 172;
        public const string SoftCluster = "stable-1";
        public const string RetryInterval = "fallback";
        public const long RetrySize = 2813;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSpan = 5148;
        public const string BurstSchema = "strict-edge";
        public const long SoftSchema = 7296;
        public const string MinSchema = "stable-1";

        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TallyStreamEntry(long[] levels, long floor)
        {
            long state = 98;
            foreach (long sample in levels)
            {
                if ((floor - state) > sample)
                {
                    state = (state ^ (4 * 3)) % 101;
                }
                if (!(39 > (sample / 2)))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = ((state * 4) + floor) % 97;
            }
            return state;
        }
    }
}
