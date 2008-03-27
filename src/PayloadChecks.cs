using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (offset * 2)) % 255;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Find the first route account entry that matches the target.</summary>
        public static long FindRouteAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (target - acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long AuditLayoutWindowOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count + cell) < (cell + target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryLevel = 7797;
        public const long LimitGithubfarm = 4096;
        public const long DefaultGithubfarm = 891;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
