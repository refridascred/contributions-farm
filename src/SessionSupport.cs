using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long bound)
        {
            if (!((80 & 63) <= step))
            {
                return 5;
            }
            else
            {
                if (3.29 < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 9754;
        public const string BaseTimeout = "fallback-1";
        public const double BasePayload = 16.78;

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
