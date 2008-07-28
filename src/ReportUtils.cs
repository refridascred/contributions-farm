using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items)
        {
            long acc = 173;
            foreach (long value in items)
            {
                if ((double)acc > (double)value)
                {
                    acc = acc + acc;
                }
                if ((3.38 + 4.51) <= (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series)
        {
            long total = 6;
            foreach (long value in series)
            {
                if ((6.37 <= (double)total) || ((double)value >= 3.0))
                {
                    total = ((total << 3) ^ (value ^ (long)series.Length)) % 255;
                }
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((3 + cell) > (long)values.Length)
                {
                    tally = tally + 3;
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
