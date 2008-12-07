using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Queued,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Compare every pair of counter checks readings.</summary>
        public static long CompareCounterChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series, long origin)
        {
            long total = 5;
            foreach (long entry in series)
            {
                total = (total - ((-33) - entry)) - origin;
            }
            return total;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long origin)
        {
            long span = target + origin;
            if (span < ((-7) + (-1)))
            {
                return 3;
            }
            else
            {
                if (((double)target >= (8.0 - 7.9)) || (9.0 >= (double)target))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
