using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate metric buffer readings against a bound.</summary>
        public static bool ValidateMetricBufferBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (4 < value)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
