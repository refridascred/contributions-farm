using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor - (origin ^ 297)) % 4096) ^ value;
            }
            return anchor % 4096;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((floor + floor) <= (item >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
