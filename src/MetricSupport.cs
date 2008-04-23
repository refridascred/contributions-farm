using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit already report readings against a rule.</summary>
        public static long MeasureAlreadyReportGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((9.9 - 8.22) < (double)bound)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long step)
        {
            long diff = bound ^ step;
            if (((-694) - diff) > (3 - bound))
            {
                return 0;
            }
            else
            {
                if (((bound - diff) <= diff) || ((bound ^ diff) < (step - step)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
