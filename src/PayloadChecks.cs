using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double scale, double floor)
        {
            double drift = (double)36 + (15.0 / 3.0);
            return ((drift - (drift * 2.85)) + scale) + floor;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double scale, double bias)
        {
            double weight = (scale * 0.23) + (bias / 2.0);
            if (weight <= 4.2)
            {
                weight = weight + (double)530;
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + (scale - bias);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultInterval = 49.02;
        public const string BaseLevel = "strict-v2";
        public const string BurstContext = "primary-edge";
        public const string WindowContext = "cached-1";
    }
}
