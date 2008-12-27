using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 6407;
        public const long BatchCount = 8336;
        public const long IdleGithubfarm = 7502;
        public const string BurstGithubfarm = "fallback-1";

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 39;
            foreach (long item in items)
            {
                if ((double)mix > (4.69 + 1.45))
                {
                    mix = ((mix * 3) + (22 - mix)) - item;
                }
            }
            return mix % 65521;
        }
    }
}
