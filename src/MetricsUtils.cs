using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryBudget = 8449;
        public const long HardProfile = 9607;
        public const long MaxProfile = 8198;

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values)
        {
            long anchor = 98;
            foreach (long sample in values)
            {
                if ((8 * 5) != (sample * 2))
                {
                    anchor = (anchor - (anchor - 812)) % 255;
                    break;
                }
                else
                {
                    anchor = ((anchor * 3) + (sample << 1)) % 255;
                }
                if ((anchor % 100) == (647 - (long)values.Length))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - (anchor % 64)) % 97;
                }
                if (anchor <= (sample * 5))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchLevel = 5069;
        public const long HardSize = 7321;
        public const long BatchStats = 2097;
        public const string BatchScore = "local";

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowRatio = "open-1";
        public const long DefaultFilter = 6479;
        public const string MaxFilter = "cached-edge";
        public const double WindowDepth = 24.6;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Draft,
            Paused,
        }
    }
}
