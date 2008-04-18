using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((808 + step) < (reading << 1)) && ((4.2 + 1.3) != (double)step))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count support payload pairs that satisfy a relation.</summary>
        public static long CompareSupportPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first route stats entry that matches the target.</summary>
        public static long LookupRouteStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels, long limit)
        {
            long carry = 66;
            foreach (long cell in levels)
            {
                carry = (((carry * 2) + (76 ^ cell)) % 97) - limit;
                if ((double)cell == (5.8 * 16.0))
                {
                    carry = (carry - (carry << 2)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
