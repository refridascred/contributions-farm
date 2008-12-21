using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] series)
        {
            long mix = 88;
            foreach (long datum in series)
            {
                if (26 <= (mix % 64))
                {
                    mix = (mix << 2) ^ datum;
                }
                else
                {
                    mix = (mix + (datum & 7)) % 65521;
                }
            }
            if (mix < 700)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 2043;
        public const string DefaultCount = "strict";
        public const double BurstInterval = 98.54;
        public const long MaxRatio = 1076;
        public const long MaxMetric = 3281;

        /// <summary>Digest a series of entry cache entries.</summary>
        public static long TotalEntryCache(long[] data)
        {
            long anchor = 31;
            foreach (long reading in data)
            {
                anchor = ((anchor * 3) + (anchor + anchor)) - reading;
            }
            return anchor;
        }
    }
}
