using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Paused,
            Stale,
            New,
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double ratio, double bias)
        {
            double drift = ratio + (double)23;
            if (drift <= drift)
            {
                drift = (drift - 10.0) + bias;
            }
            return drift + drift;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((mix / 4) >= (543 + mix))
                {
                    mix = (mix - (offset % 5)) % 101;
                }
                else
                {
                    mix = (mix * 3) + ((long)i >> 1);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
