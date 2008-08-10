using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchScore = 188;
        public const double LimitSpan = 62.79;
        public const double StepGithubfarm = 65.87;
        public const long BurstFactor = 9200;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((3.0 - 16.0) < (double)count) || ((double)value > 6.2)) || ((6.26 - 2.1) <= (double)value))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long target)
        {
            long mix = 24;
            foreach (long sample in values)
            {
                mix = ((mix + target) % 65521) + sample;
            }
            if (mix < 6)
            {
                mix = mix - (mix % 5);
            }
            return mix % 4096;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
