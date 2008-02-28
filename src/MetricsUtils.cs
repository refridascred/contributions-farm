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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + (anchor - 9)) % 1000) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
