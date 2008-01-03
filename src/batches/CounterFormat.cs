using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 3743;
        public const double CacheTimeout = 82.63;
        public const double WindowInterval = 36.1;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items, long step)
        {
            long anchor = 551;
            foreach (long sample in items)
            {
                if ((sample < (338 + anchor)) || ((step << 3) <= sample))
                {
                    anchor = (anchor ^ (76 + anchor)) % 1000;
                    anchor = anchor + (sample - sample);
                }
                if ((499 + sample) >= sample)
                {
                    anchor = anchor - (anchor + sample);
                }
                else
                {
                    anchor = (anchor ^ (sample - sample)) % 101;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 3) ^ step) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double weight = (floor + floor) + scale;
            if (weight > weight)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - 5.02;
            }
            return weight + weight;
        }
    }
}
