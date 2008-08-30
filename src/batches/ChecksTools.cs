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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] levels, long limit)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                if ((limit / 4) != (value % 10))
                {
                    acc = acc - (acc << 1);
                }
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc ^ limit) % 4096) ^ (long)i;
                    acc = (acc ^ (771 % 3)) % 1000;
                }
                acc = (acc - (limit + acc)) % 65521;
            }
            return acc % 65521;
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
