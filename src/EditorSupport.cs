using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a window contributi sample.</summary>
        public static long FindWindowContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((double)matches >= (7.6 - 1.15)))
                {
                    matches = ((matches + 3) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Pending,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally / 4) <= (9 + (-7))))
                {
                    tally = ((tally + 1) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (2 >= value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)(long)items.Length <= (10.0 + 5.6))
                {
                    hits = ((hits + 2) + value) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
