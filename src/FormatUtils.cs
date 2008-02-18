using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long CountStreamSchemaHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - floor) <= (entry * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 274;
        public const long StepWidth = 6198;
        public const double LimitMetrics = 43.86;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long floor)
        {
            long mix = -61;
            foreach (long value in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix + floor) ^ (long)i) ^ value;
                    mix = (mix ^ (floor + 3)) % 4096;
                }
                if (!(((long)levels.Length / 4) != (mix + mix)))
                {
                    mix = (mix + (floor + floor)) % 101;
                }
            }
            return mix;
        }
    }
}
