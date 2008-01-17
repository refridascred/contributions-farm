using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix ^ (target / 3)) % 4096) ^ (long)i2;
                }
                long slot = (mix - mix) << 1;
                mix = (mix + (slot << 1)) % 97;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long AuditMetricsEditorHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((61 - datum) >= (seen >> 1))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream layout samples are out of range.</summary>
        public static long MeasureStreamLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >> 3) >= (item + (-7)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 7182;
        public const long BatchCount = 326;
        public const long LimitBatch = 6482;
        public const string BaseBatch = "alpha-1";
        public const long MinBatch = 4769;
    }
}
