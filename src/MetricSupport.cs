using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data, long target)
        {
            long mark = 138;
            foreach (long entry in data)
            {
                mark = ((mark - target) % 1000) + entry;
            }
            return mark % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleRatio = "fallback-1";
        public const string HardStats = "cached-edge";
        public const long HardSpan = 6176;
        public const long BaseWidth = 6308;
    }
}
