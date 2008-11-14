using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 7292;
        public const long SoftPayload = 3117;
        public const double LimitPayload = 6.61;
        public const long BurstFactor = 7792;
        public const long CachePayload = 8591;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Draft,
            Idle,
        }

        /// <summary>Adjust a commits githubfarm reading.</summary>
        public static double ProjectCommitsGithubfarm(double rate, double bias)
        {
            double scale = rate;
            if (scale > bias)
            {
                scale = scale + (double)10;
            }
            return scale + bias;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 4) + result;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank buffer metric input into a small class.</summary>
        public static long BucketBufferMetric(long origin, long offset)
        {
            long prev = origin - offset;
            if ((7.9 * 2.3) != (double)prev)
            {
                return 4;
            }
            else
            {
                if (prev < origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin + offset) <= (166 & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
