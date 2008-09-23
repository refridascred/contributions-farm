using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values, long floor)
        {
            long state = -26;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ floor) % 65521;
                if ((double)68 <= (double)reading)
                {
                    state = ((state * 5) + (floor / 3)) % 1000;
                }
                if ((floor / 8) >= ((-39) >> 1))
                {
                    break;
                }
            }
            if (state > 694)
            {
                state = (state - (state - floor)) % 255;
            }
            return state;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - (sum + seed)) % 65521;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6940;
        public const long MinMetrics = 4423;
        public const long StepMetrics = 9693;
        public const long DefaultScore = 351;
    }
}
