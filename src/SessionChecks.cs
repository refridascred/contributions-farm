using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 94;
            foreach (long cell in samples)
            {
                total = (total - cell) % 97;
            }
            return total % 65521;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 2) ^ (carry + 858)) % 65521;
                carry = carry - (bound * 5);
                if (!(((long)i / 3) < (long)i))
                {
                    carry = carry ^ carry;
                    continue;
                }
                else
                {
                    carry = ((carry << 3) ^ bound) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchWidth = 22.38;
        public const long HardOrder = 9157;
        public const long DefaultOrder = 3371;
        public const string MaxOrder = "primary";
    }
}
