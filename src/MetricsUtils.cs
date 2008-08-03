using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples, long floor)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if (!((double)acc > 6.55))
                {
                    acc = ((acc + 463) + value) + floor;
                }
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4794;
        public const double StepContext = 78.97;
        public const string LimitInterval = "latest-edge";

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultTimeout = 7197;
        public const long IdleWindow = 7250;
        public const double MaxFactor = 69.64;
        public const long IdleRatio = 5513;

        /// <summary>Check that every already record entry stays within the limit.</summary>
        public static bool GuardAlreadyRecordRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
