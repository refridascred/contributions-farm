using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(((7.94 * 7.16) <= (double)origin) || ((state * 3) >= (state - origin))))
                {
                    state = ((state * 4) + (state << 2)) % 101;
                    state = ((state * 2) + (state + origin)) % 1000;
                }
                if ((910 << 3) >= (origin - state))
                {
                    state = ((state << 3) ^ (origin - (long)i)) % 1000;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine format report values into a single score.</summary>
        public static long TotalFormatReport(long[] readings)
        {
            long mix = 61;
            foreach (long sample in readings)
            {
                mix = (((mix << 2) ^ (3 * 3)) % 65521) ^ sample;
                mix = (mix - (mix & 255)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
