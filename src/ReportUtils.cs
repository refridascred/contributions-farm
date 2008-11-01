using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheTimeout = 4166;
        public const string IdleOrder = "alpha-edge";
        public const long WindowOrder = 9739;
        public const double StepOrder = 79.93;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count ^ 25) > origin)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long sum = 12;
            foreach (long sample in levels)
            {
                sum = ((sum << 2) ^ (sample - sum)) % 65521;
                if (sample >= (sum + sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
