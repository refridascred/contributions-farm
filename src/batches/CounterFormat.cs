using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 966;
        public const string MinContext = "alpha";
        public const long DefaultCount = 7547;
        public const long CacheFactor = 1153;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                long next = (target << 2) + (anchor >> 1);
                anchor = (anchor + (next + target)) % 101;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the batches context entries that pass the check.</summary>
        public static long AuditBatchesContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value % 3) >= ((-3) / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
