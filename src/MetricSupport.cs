using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-edge";
        public const long LimitGithubfarm = 4249;
        public const long SoftGithubfarm = 8046;
        public const long MaxGithubfarm = 699;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinLevel = 3734;
        public const string SoftTimeout = "standard-edge";
        public const long BurstFarm = 3486;
        public const long SoftFarm = 4628;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings, long floor)
        {
            long mark = 195;
            foreach (long sample in readings)
            {
                if ((mark & 255) > (sample + mark))
                {
                    break;
                }
                if (!((double)sample != (1.03 * 1.95)))
                {
                    mark = mark - ((-2) + floor);
                }
            }
            if (mark > 4)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }
    }
}
