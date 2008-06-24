using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already notes sample.</summary>
        public static long LookupAlreadyNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of contributi stats entries.</summary>
        public static long TotalContributiStats(long[] values, long seed)
        {
            long anchor = 0;
            foreach (long entry in values)
            {
                anchor = (anchor << 2) ^ (entry - 32);
                anchor = anchor + (seed + anchor);
                anchor = (anchor * 2) + (anchor + anchor);
            }
            if (anchor > 93)
            {
                anchor = ((anchor * 4) + seed) % 255;
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample >= (tally - (-10)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
