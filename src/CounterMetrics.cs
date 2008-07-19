using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit entry tools readings against a rule.</summary>
        public static long MeasureEntryToolsHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches << 2) >= ((-1) + 5))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheInterval = 451;
        public const double DefaultFilter = 20.35;
        public const double BurstFilter = 30.94;
        public const long StepBudget = 6485;
        public const string StepSize = "local-1";

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc - ((long)i - (long)i)) % 4096;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
