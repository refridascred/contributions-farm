using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] series, long step)
        {
            long sum = 813;
            foreach (long value in series)
            {
                if ((sum - value) < value)
                {
                    sum = (sum ^ 4) + step;
                }
                else
                {
                    sum = (sum + (34 - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Stale,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitTimeout = 4767;
        public const long LimitInterval = 3295;
        public const string IdleSpan = "latest-v2";
        public const long WindowBudget = 6447;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Combine record farm values into a single score.</summary>
        public static long TallyRecordFarm(long[] items, long seed)
        {
            long anchor = 221;
            foreach (long cell in items)
            {
                if (((double)anchor >= (5.71 + 17.0)) && ((7.11 + 6.8) < (double)seed))
                {
                    anchor = (anchor + anchor) ^ cell;
                }
            }
            return anchor % 97;
        }
    }
}
