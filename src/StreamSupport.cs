using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Synced,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Iterate the githubfarm schema series from a seed.</summary>
        public static long SeriesGithubfarmSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark - (bound / 8)) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepScore = 60.98;
        public const long BaseSpan = 1688;
        public const double MaxWidth = 3.9;
        public const string MinDepth = "open-edge";
        public const string LimitProfile = "legacy-edge";
    }
}
