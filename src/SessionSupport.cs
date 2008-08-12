using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5490;
        public const long LimitInterval = 927;
        public const long DefaultSize = 2847;
        public const long MaxLevel = 3608;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (7.7 + 5.0))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count * 3) > (target - value)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
