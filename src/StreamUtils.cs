using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double scale, double offset)
        {
            double gain = offset;
            if (gain < (gain * 7.79))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - 1.9;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (scale * 5.2)) - (double)(long)i;
            }
            return gain - (double)6;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen % 8) > (6 - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 5218;
        public const long BaseSize = 4114;
        public const long CacheScore = 3239;
        public const long BaseOrder = 3136;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Stale,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            Paused,
            Failed,
            Ready,
        }
    }
}
