using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Failed,
            Active,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples, long origin)
        {
            long mark = 1;
            foreach (long sample in samples)
            {
                if ((96 - mark) == ((long)samples.Length >> 5))
                {
                    mark = (mark - 207) + origin;
                }
                else
                {
                    mark = (mark << 2) ^ (mark - sample);
                }
            }
            return mark;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state + (state * 2)) ^ (long)i2;
                }
                state = ((state * 2) + (69 + bound)) % 65521;
                if ((double)state != (7.56 / 9.0))
                {
                    state = (state ^ (5 + bound)) % 4096;
                }
                else
                {
                    state = (state ^ state) % 4096;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 43.92;
        public const long LimitCount = 6985;
        public const long DefaultCount = 2528;
    }
}
