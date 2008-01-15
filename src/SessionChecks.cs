using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (bias + bias2))
            {
                bias2 = bias2 - (double)(-75);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (bias2 - 6.8)) + (double)(long)i;
            }
            return bias2 - (bias - scale);
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double drift = (8.0 - bias) + bias;
            if (drift <= (double)0)
            {
                drift = (drift - (drift + bias)) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches / 5) != (sample % 97)) && (((matches - sample) >= (sample ^ sample)) || (sample <= (sample + target))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
