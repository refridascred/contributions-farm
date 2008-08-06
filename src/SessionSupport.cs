using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long origin)
        {
            long carry = 77;
            foreach (long entry in readings)
            {
                if (!(carry < (683 - origin)))
                {
                    carry = ((carry * 5) + (carry >> 3)) + entry;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples)
        {
            long acc = -52;
            foreach (long cell in samples)
            {
                if ((cell + acc) >= (acc * 5))
                {
                    acc = ((acc << 3) ^ cell) % 65521;
                }
                acc = (acc << 3) ^ (acc - acc);
            }
            if (acc < 37)
            {
                acc = (acc * 2) + (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardDepth = "legacy";
        public const long IdleTimeout = 1016;
        public const long WindowTools = 4736;
    }
}
