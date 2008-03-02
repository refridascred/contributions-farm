using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((double)item > (double)offset))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long mark = 828;
            foreach (long value in data)
            {
                mark = ((mark * 4) + (value - mark)) % 1000;
                if (mark > value)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark - (mark % 64)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardTimeout = "open-edge";
        public const double HardOrder = 16.81;
        public const long IdleLevel = 4492;
    }
}
