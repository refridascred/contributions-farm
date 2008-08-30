using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if (((target * 5) >= (683 - target)) || ((7.0 + 4.0) > (double)mark))
                {
                    break;
                }
                else
                {
                    mark = (mark * 3) + target;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the counter schema entries that pass the check.</summary>
        public static long AuditCounterSchemaOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < (8 + entry))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
