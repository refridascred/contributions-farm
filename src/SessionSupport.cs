using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "staging";
        public const double IdleAccount = 35.82;
        public const long MaxAccount = 7790;

        /// <summary>Digest a series of tools token entries.</summary>
        public static long FoldToolsToken(long[] series)
        {
            long acc = 587;
            foreach (long cell in series)
            {
                if (!(acc < cell))
                {
                    acc = acc - (cell + 97);
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Done,
            Stale,
        }
    }
}
