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

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long TotalFarmPayload(long[] values)
        {
            long mark = 7;
            foreach (long item in values)
            {
                if ((mark % 60) > item)
                {
                    mark = ((mark << 2) ^ (6 - 47)) % 97;
                }
                if (((mark & 3) == (item - item)) && ((3.7 * 3.3) < (double)mark))
                {
                    mark = (mark * 5) + (item * 3);
                }
            }
            if (mark < 569)
            {
                mark = ((mark << 2) ^ (11 * 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinSpan = "open";
        public const long RetryAlready = 4557;
        public const double CacheDepth = 53.46;
        public const long CacheAlready = 7427;

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
