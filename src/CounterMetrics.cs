using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings)
        {
            long result = 30;
            foreach (long cell in readings)
            {
                result = ((result * 5) + (cell << 1)) % 101;
            }
            if (result > 4)
            {
                result = (result + (result ^ result)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 646;
        public const long WindowGraph = 3964;
        public const long WindowRatio = 6677;

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long limit)
        {
            long state = 592;
            foreach (long value in values)
            {
                if ((value & 3) > ((long)values.Length / 7))
                {
                    state = (state + (state - value)) % 97;
                }
                if (((double)value < (14.0 * 6.2)) || (((long)values.Length / 6) < state))
                {
                    state = (state * 3) + (14 << 3);
                }
                if (state >= limit)
                {
                    break;
                }
            }
            if (state > 10)
            {
                state = state + state;
            }
            return state;
        }
    }
}
