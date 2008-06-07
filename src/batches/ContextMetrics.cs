using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long origin)
        {
            if (((origin + origin) <= 888) && ((6.2 + 3.6) <= (double)limit))
            {
                return 0;
            }
            else
            {
                if ((limit ^ origin) != (origin + 798))
                {
                    return 7;
                }
                else
                {
                    if ((origin > (limit + limit)) || ((11 & 15) <= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((double)bound > (double)value) || ((bound + value) >= (value / 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCount = 86.57;
        public const long BaseCommits = 2008;
        public const long HardCommits = 600;
        public const long BurstSize = 865;
        public const long BurstCommits = 7147;

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 57.36;
        public const double DefaultToken = 90.66;
        public const long HardToken = 5177;
        public const long StepSize = 6900;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Locked,
            Active,
            Failed,
        }
    }
}
