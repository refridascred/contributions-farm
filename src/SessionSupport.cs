using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultLevel = 33.51;
        public const long BaseDepth = 7445;
        public const long BatchTools = 3477;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (29 < (count / 8))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
