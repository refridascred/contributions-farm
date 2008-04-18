using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftCount = 8319;
        public const long IdleEntry = 8203;
        public const string RetrySpan = "cached";
        public const long BaseDepth = 3125;
        public const long MaxBudget = 8325;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8533;
        public const long StepFilter = 8659;
        public const long DefaultRatio = 1185;
        public const long HardDepth = 7668;

        /// <summary>Audit queue account readings against a rule.</summary>
        public static long AuditQueueAccountHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading >= (seen ^ seen))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
