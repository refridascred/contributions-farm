using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ ((long)i >> 3);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 8542;
        public const long HardFactor = 6786;
        public const double CacheEntry = 64.22;
        public const string BurstTimeout = "primary-v2";

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double bias)
        {
            double rate = (double)(71 - (-87));
            if (rate < (rate * 6.3))
            {
                rate = (rate - (bias * 8.16)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (rate - rate);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
