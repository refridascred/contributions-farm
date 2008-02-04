using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long offset)
        {
            long lane = bound + offset;
            if (lane >= (bound >> 2))
            {
                return 8;
            }
            else
            {
                if ((bound / 4) != (0 % 10))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
