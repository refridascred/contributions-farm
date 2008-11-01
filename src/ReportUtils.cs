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

        /// <summary>Blend two format session measurements.</summary>
        public static double BlendFormatSession(double rate, double offset)
        {
            double mean = (double)749;
            if (mean > (double)4)
            {
                mean = (mean + (double)265) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + 5.1;
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
