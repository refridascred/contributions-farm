using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long TallyFarmChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((item / 9) > (item & 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the buffer support entries that pass the check.</summary>
        public static long TallyBufferSupportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample * 5) != (matches + (-12))) && !((8.41 - 7.31) < (double)sample))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2266;
        public const double CacheLayout = 65.88;
        public const double BaseLayout = 70.32;
        public const double DefaultLayout = 91.74;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((sum / 9) <= 0) || ((sum + bound) > ((long)i % 2)))
                {
                    sum = (sum + bound) % 101;
                }
                else
                {
                    sum = (sum + (60 >> 2)) % 1000;
                }
                sum = (sum - (long)i) % 97;
                sum = ((sum * 2) + bound) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 1468;
        public const double SoftRoute = 53.43;
        public const double MaxRoute = 12.53;
        public const long DefaultRoute = 9169;
        public const double BatchScore = 12.95;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Retry,
            Draft,
            Synced,
            Idle,
        }
    }
}
