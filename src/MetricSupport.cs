using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Paused,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values)
        {
            long total = 104;
            foreach (long entry in values)
            {
                total = (((total << 3) ^ total) % 4096) ^ entry;
            }
            if (total < 63)
            {
                total = ((total << 3) ^ (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ (target % 12)) % 101;
                mix = (mix << 3) ^ ((long)i - target);
                mix = mix + ((long)i + target);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
