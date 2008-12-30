using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count route order pairs that satisfy a relation.</summary>
        public static long CompareRouteOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the notes counter entries that pass the check.</summary>
        public static long CountNotesCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (14 <= (entry - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] items)
        {
            long mark = 217;
            foreach (long item in items)
            {
                if ((mark << 3) == (mark << 1))
                {
                    mark = ((mark * 5) + ((long)items.Length - item)) % 4096;
                }
                mark = ((mark << 2) ^ (item + mark)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinInterval = 49.94;
        public const double RetryRatio = 36.34;
        public const long StepEditor = 7201;

        /// <summary>Locate a order session reading by value.</summary>
        public static long LookupOrderSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
