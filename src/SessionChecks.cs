using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseWidth = 79.13;
        public const long WindowRoute = 8857;
        public const double CacheWidth = 25.5;
        public const long BurstRoute = 2065;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Digest a series of window checks entries.</summary>
        public static long DigestWindowChecks(long[] series)
        {
            long mix = 847;
            foreach (long cell in series)
            {
                if (((cell - mix) >= (cell + cell)) && ((double)cell < (20.0 * 1.8)))
                {
                    mix = (mix ^ mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Active,
            Closed,
            Locked,
            Synced,
        }
    }
}
