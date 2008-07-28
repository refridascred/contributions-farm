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

        /// <summary>Project the next checks entry value.</summary>
        public static double BlendChecksEntry(double gain, double span)
        {
            double mean = span;
            if (mean > gain)
            {
                mean = mean - (4.0 + 16.0);
            }
            return mean + (span * 8.5);
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
