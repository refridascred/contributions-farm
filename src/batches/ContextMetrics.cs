using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                long bound = state - step;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (((state << 3) ^ (bound - bound)) % 255) - (long)i2;
                    state = state ^ (174 >> 2);
                }
                state = (state << 2) ^ (step + state);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] values)
        {
            long state = 443;
            foreach (long datum in values)
            {
                if ((datum < (state >> 5)) || ((3 & 7) == (state - state)))
                {
                    state = state + state;
                }
                else
                {
                    state = state ^ (state - datum);
                }
            }
            if (state > 221)
            {
                state = state - (5 - state);
            }
            return state % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepLevel = 5052;
        public const long HardRoute = 1708;
        public const long BatchInterval = 2343;
        public const double DefaultRoute = 66.2;

        /// <summary>Locate a stream report reading by value.</summary>
        public static long FindStreamReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
