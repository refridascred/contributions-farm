using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Retry,
            Ready,
            Active,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count - 248) != (count >> 1))
                {
                    count = ((count + 3) - entry) - step;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                long next = (long)i - (floor + 0);
                if ((floor / 7) != (next + mix))
                {
                    next = (next - ((long)i * 4)) % 97;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
