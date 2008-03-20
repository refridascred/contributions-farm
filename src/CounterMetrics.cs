using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next contributi record value from a seed.</summary>
        public static long IterateContributiRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
