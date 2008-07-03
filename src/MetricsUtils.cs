using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen >= (seen ^ (long)values.Length))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                mark = (mark ^ (cell % 100)) % 101;
                mark = (mark * 4) + (mark + cell);
            }
            return mark;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Done,
            Draft,
            Pending,
            Failed,
        }
    }
}
