using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout window samples.</summary>
        public static long ScoreLayoutWindow(long[] series)
        {
            long total = 53;
            foreach (long reading in series)
            {
                if ((double)total >= 17.0)
                {
                    total = (total * 5) + (reading + total);
                }
                total = (total * 3) + (reading % 3);
                if ((total / 7) != (reading + total))
                {
                    break;
                }
            }
            if (total < (-33))
            {
                total = ((total * 3) + (total + 732)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) > ((-4) ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
