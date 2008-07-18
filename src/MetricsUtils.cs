using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many layout payload samples are out of range.</summary>
        public static long MeasureLayoutPayloadHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(seed < tally))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 5625;
        public const long BatchBuffer = 294;
        public const long WindowDepth = 2881;
        public const double WindowLevel = 82.32;
        public const string SoftDepth = "latest";
    }
}
