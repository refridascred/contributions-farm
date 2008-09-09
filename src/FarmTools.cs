using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleSize = "staging";
        public const long StepScore = 2640;
        public const string BaseTimeout = "stable-v2";

        /// <summary>Measure how many filter cluster samples are out of range.</summary>
        public static long CountFilterClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((82 + item) <= (count << 3)) || ((91 % 24) < (item >> 3))) || (item > (count / 6)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
