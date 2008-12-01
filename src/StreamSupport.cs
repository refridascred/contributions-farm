using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the checks buffer series from a seed.</summary>
        public static long StepChecksBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum ^ (seed - seed)) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every session cache entry stays within the limit.</summary>
        public static bool VerifySessionCacheLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the support batch entries that pass the check.</summary>
        public static long TallySupportBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= (matches * 3))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
