using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "cached";
        public const double BurstBudget = 30.38;
        public const string WindowGithubfarm = "stable-v2";
        public const long IdleGithubfarm = 4929;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Stale,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Grade a queue record value against two limits.</summary>
        public static long BucketQueueRecord(long bound, long limit)
        {
            if ((double)limit <= 5.5)
            {
                return 4;
            }
            else
            {
                if ((limit * 2) != (limit % 64))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two layout payload measurements.</summary>
        public static double SmoothLayoutPayload(double scale, double floor)
        {
            double gain = (floor + floor) * 0.3;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (gain / 8.0)) + (double)(long)i) - scale;
            }
            return gain - (gain * 8.97);
        }
    }
}
