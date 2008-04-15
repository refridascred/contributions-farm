using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count already batches pairs that satisfy a relation.</summary>
        public static long CompareAlreadyBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every counter stats entry stays within the limit.</summary>
        public static bool CheckCounterStatsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Idle,
            New,
            Queued,
            Locked,
        }
    }
}
