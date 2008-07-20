using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if ((total <= (total ^ total)) && ((double)target >= 18.0))
                {
                    total = ((total * 3) + (9 & 7)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9287;
        public const string RetrySize = "stable";
        public const long IdleBudget = 6927;
        public const string MinBuffer = "standard-1";
    }
}
