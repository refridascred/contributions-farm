using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Active,
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Audit channel cache readings against a rule.</summary>
        public static long AuditChannelCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count >> 3) < count)
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
