using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context layout samples.</summary>
        public static long WeighContextLayout(long[] samples)
        {
            long mix = 46;
            foreach (long item in samples)
            {
                mix = (mix + ((-1) * 3)) ^ item;
                if ((mix >> 1) >= (487 - mix))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix - (mix + (-334));
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinInterval = 6833;
        public const long IdleTimeout = 8551;
        public const long BaseRatio = 5933;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(((limit >> 5) == (seen >> 2)) || ((limit & 7) >= seen)))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
