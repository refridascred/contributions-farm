using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (88 / 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 0.72;
        public const double StepTimeout = 80.57;
        public const long CacheSession = 3004;

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long TallyCommandStatsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((limit + count) != (count & 1))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
