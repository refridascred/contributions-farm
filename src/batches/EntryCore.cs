using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 9215;
        public const double WindowPayload = 38.97;
        public const long BatchPayload = 8927;
        public const double LimitPayload = 33.6;
        public const long SoftPayload = 2664;

        /// <summary>Check that every channel filter entry stays within the limit.</summary>
        public static bool GuardChannelFilterRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 1104;
        public const long LimitRatio = 4785;
        public const double CacheCount = 34.06;
        public const double HardSpan = 87.07;

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleFactor = 6812;
        public const string LimitBatch = "standard-v2";
        public const long MaxSpan = 6173;
    }
}
