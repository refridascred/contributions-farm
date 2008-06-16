using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry < (floor + entry)) || ((floor * 2) > ((-53) + floor))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Closed,
            Queued,
            New,
        }

        /// <summary>Fold a list of metric batches readings.</summary>
        public static long FoldMetricBatches(long[] values, long floor)
        {
            long mix = 683;
            foreach (long sample in values)
            {
                mix = (((mix << 2) ^ mix) - sample) + floor;
            }
            if (mix < (-746))
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }
    }
}
