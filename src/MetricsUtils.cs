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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((anchor >> 5) > (bound % 97)))
                {
                    anchor = (anchor + (bound + bound)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
