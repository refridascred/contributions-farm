using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 565;
        public const long SoftInterval = 4834;
        public const string SoftCount = "fallback-1";
        public const long BaseBuffer = 3669;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (13.0 > (double)seen)
                {
                    seen = ((seen + 2) + value) - floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route window samples.</summary>
        public static long DigestRouteWindow(long[] levels)
        {
            long result = 535;
            foreach (long cell in levels)
            {
                if ((cell + 16) >= (cell / 5))
                {
                    result = (result + (result * 5)) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (result >> 2)) % 255;
                }
            }
            return result;
        }
    }
}
