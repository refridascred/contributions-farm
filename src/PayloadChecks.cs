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

        /// <summary>Audit record session readings against a rule.</summary>
        public static long TallyRecordSessionOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item << 2) <= (hits - item))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = (double)(3 * 2);
            if (gain < (scale + 4.3))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + 2.7;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)1) + (double)(long)i;
            }
            return gain + (gain * 9.6);
        }
    }
}
