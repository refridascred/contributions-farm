using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen >= (2.6 / 7.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches % 24) == (item + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine route order values into a single score.</summary>
        public static long CombineRouteOrder(long[] values, long bound)
        {
            long score = 675;
            foreach (long reading in values)
            {
                if ((double)reading == (20.0 + 6.63))
                {
                    score = ((score - (reading + score)) % 97) - bound;
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
