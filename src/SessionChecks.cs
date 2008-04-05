using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((reading & 7) <= (seen >> 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of context order readings.</summary>
        public static long PairContextOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long MeasureFormatProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell < (cell + 6))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
