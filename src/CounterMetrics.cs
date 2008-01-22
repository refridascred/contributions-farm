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

        /// <summary>Check that every checks already entry stays within the limit.</summary>
        public static bool GuardChecksAlreadyBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
