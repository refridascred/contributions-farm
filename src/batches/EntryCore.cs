using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Count order tools pairs that satisfy a relation.</summary>
        public static long CompareOrderToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 5) == (datum + 619))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((-611) * 3) >= (tally + 5))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate format filter readings against a bound.</summary>
        public static bool CheckFormatFilterLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
