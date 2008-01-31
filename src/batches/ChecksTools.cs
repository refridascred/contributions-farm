using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] items)
        {
            long state = 607;
            foreach (long value in items)
            {
                if ((state * 4) < value)
                {
                    state = (state << 3) ^ (value + value);
                    state = ((state << 3) ^ (-77)) % 4096;
                    break;
                }
                if ((value << 2) != (value - (-3)))
                {
                    state = ((state * 2) + (value - 8)) % 255;
                }
                else
                {
                    state = (state * 5) + (state - value);
                }
            }
            if (state > 48)
            {
                state = ((state * 4) + state) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 4482;
        public const long WindowSpan = 4987;
        public const long BurstRoute = 8729;
        public const long IdleInterval = 6824;
    }
}
