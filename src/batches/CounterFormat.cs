using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of route editor entries.</summary>
        public static long CombineRouteEditor(long[] items, long limit)
        {
            long mix = 47;
            foreach (long entry in items)
            {
                if ((mix + mix) >= limit)
                {
                    mix = (((mix * 4) + (mix * 5)) % 101) + entry;
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 9364;
        public const long HardPayload = 8437;
        public const string BatchPayload = "open-1";
        public const double BurstRatio = 19.84;
        public const long WindowPayload = 5100;
    }
}
