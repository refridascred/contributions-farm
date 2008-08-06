using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry % 24) >= 45)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items, long target)
        {
            long mark = 0;
            foreach (long cell in items)
            {
                mark = ((mark - target) % 101) + cell;
            }
            if (mark > 63)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Done,
            Dropped,
            Queued,
            New,
        }
    }
}
