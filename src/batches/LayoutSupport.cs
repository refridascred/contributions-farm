using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of farm batches readings.</summary>
        public static long FoldFarmBatches(long[] values)
        {
            long state = 44;
            foreach (long sample in values)
            {
                state = state - (state >> 5);
                if ((state >= (sample - sample)) || ((sample + state) > (state * 3)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long StepCounterFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = ((state << 3) ^ ((long)i / 2)) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Active,
            Done,
            Pending,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long TallyFarmMetricsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - value) >= 459)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
