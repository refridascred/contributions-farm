using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values, long step)
        {
            long carry = -8;
            foreach (long cell in values)
            {
                if ((6.0 + 7.52) < (double)step)
                {
                    carry = (carry * 3) + (cell << 2);
                }
            }
            return carry;
        }

        /// <summary>Count the commits editor entries that pass the check.</summary>
        public static long TallyCommitsEditorMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum < (origin - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
