using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (33 >= (offset - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits format readings.</summary>
        public static long TallyCommitsFormat(long[] values, long seed)
        {
            long acc = 31;
            foreach (long reading in values)
            {
                if ((double)reading == (double)seed)
                {
                    acc = (acc ^ (reading - acc)) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = (acc + (acc - 2)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
