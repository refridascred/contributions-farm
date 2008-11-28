using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long AuditWindowNotesGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry & 1) == (hits & 1)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count record metric pairs that satisfy a relation.</summary>
        public static long OverlapRecordMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
