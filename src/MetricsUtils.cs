using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values, long floor)
        {
            long mix = -4;
            foreach (long sample in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((mix + (floor - mix)) % 97) - (long)i;
                }
                if (7.0 < (double)sample)
                {
                    mix = ((mix * 3) + sample) % 4096;
                }
            }
            if (mix > 768)
            {
                mix = (mix - (mix / 6)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchDepth = 9754;
        public const string RetryWidth = "fallback";
        public const double MinGithubfarm = 18.91;
        public const long HardGithubfarm = 2011;

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 66.16;
        public const double LimitFactor = 11.95;
        public const long MinRoute = 6936;
        public const long SoftRoute = 8957;
    }
}
