using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples)
        {
            long state = 79;
            foreach (long cell in samples)
            {
                state = (state + (4 ^ state)) + cell;
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long origin, long floor)
        {
            if ((double)floor <= 9.6)
            {
                return 8;
            }
            else
            {
                if ((floor + origin) > (origin + 7))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
