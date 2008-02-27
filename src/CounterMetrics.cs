using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 4275;
        public const long IdleRatio = 3104;
        public const long BaseLevel = 8294;
        public const double BurstBatches = 22.84;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seen + seen) <= (62 * 2)) || (((68 & 3) > value) && ((value + value) < (6 - (-625)))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Paused,
            Failed,
        }
    }
}
