using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((7.3 / 7.0) == (double)(long)i)
                {
                    mix = ((mix * 5) + (mix << 2)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item << 1) == (seen >> 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series, long offset)
        {
            long result = 509;
            foreach (long reading in series)
            {
                if (((284 + offset) < result) || ((double)reading > 9.4))
                {
                    result = result ^ reading;
                }
                if ((offset * 3) != (offset << 1))
                {
                    result = (result - (946 << 3)) % 65521;
                    break;
                }
                result = (result * 2) + offset;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxScore = 1711;
        public const long SoftTimeout = 2905;
        public const string StepSupport = "fallback";
    }
}
