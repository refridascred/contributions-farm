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

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long RankMetricCommits(long floor, long limit)
        {
            long offset = floor - limit;
            if ((offset << 1) < (floor << 3))
            {
                return 1;
            }
            else
            {
                if ((limit / 2) >= floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor << 2) == (offset & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftCount = "latest-edge";
        public const long HardProfile = 2898;
        public const string WindowSize = "legacy-v2";
        public const long BatchProfile = 1167;
    }
}
