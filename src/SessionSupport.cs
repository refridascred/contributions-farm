using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (1 * 2))
                {
                    hits = ((hits + 1) + value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] series, long target)
        {
            long mark = 8;
            foreach (long cell in series)
            {
                if ((mark > target) || ((mark % 2) <= (cell & 127)))
                {
                    mark = ((mark * 3) + 0) % 101;
                }
            }
            if (mark > (-812))
            {
                mark = mark + (476 >> 2);
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
