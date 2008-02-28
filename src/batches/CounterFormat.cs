using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples, long floor)
        {
            long total = 48;
            foreach (long sample in samples)
            {
                total = ((total << 3) ^ total) % 65521;
                total = ((total << 3) ^ (total - floor)) % 4096;
                if ((double)total == (2.0 * 2.51))
                {
                    total = total + (floor / 7);
                }
                if ((sample ^ 857) >= (864 + floor))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitCount = 1364;
        public const long MinWindow = 9655;
        public const long BaseWindow = 9738;
    }
}
