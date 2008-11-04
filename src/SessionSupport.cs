using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 6488;
        public const string HardDepth = "latest-1";
        public const long HardWindow = 5614;
        public const long DefaultWindow = 1916;
        public const long CacheBudget = 1202;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((797 ^ count) == (count & 127))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }
    }
}
