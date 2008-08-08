using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the format record entries that pass the check.</summary>
        public static long AuditFormatRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally <= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
