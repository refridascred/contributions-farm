using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 6880;
        public const long StepEntry = 7892;
        public const long MinEntry = 7840;
        public const string IdleFactor = "legacy-edge";
        public const long MaxSpan = 4389;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long bound)
        {
            long prev = target + bound;
            if (((bound - bound) >= target) && ((target / 2) == (target + bound)))
            {
                return 0;
            }
            else
            {
                if (!((double)prev == (9.51 * 1.9)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 1818;
        public const long BatchTimeout = 8897;
        public const double RetryCount = 62.87;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(-659) > (double)step)
                {
                    sum = (sum + (sum + step)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
