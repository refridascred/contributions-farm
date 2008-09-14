using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
