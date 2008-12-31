using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine support githubfarm values into a single score.</summary>
        public static long TotalSupportGithubfarm(long[] series)
        {
            long mark = 642;
            foreach (long datum in series)
            {
                if (!(7.22 > (double)datum))
                {
                    mark = mark + (8 + (-2));
                }
            }
            if (mark < 858)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
            }
            return mark % 97;
        }
    }
}
