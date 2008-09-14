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

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepInterval = 9615;
        public const long BurstCount = 6369;
        public const long BurstDepth = 3699;
        public const string SoftLevel = "open-1";
    }
}
