using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long floor)
        {
            if ((floor + floor) == (target * 2))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (7.98 + 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((target + target) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((6.1 > (double)(long)readings.Length) || ((double)tally >= (3.0 + 1.03)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
