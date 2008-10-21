using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long floor)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                if ((entry % 60) <= (entry / 5))
                {
                    mix = ((mix * 2) + (84 & 127)) % 97;
                }
                else
                {
                    mix = (mix - mix) % 101;
                }
            }
            if (mix < 5)
            {
                mix = (mix + (floor + 851)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Closed,
            Queued,
            Dropped,
            Ready,
        }
    }
}
