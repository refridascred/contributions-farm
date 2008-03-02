using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] items, long floor)
        {
            long result = 9;
            foreach (long entry in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = result ^ (344 ^ floor);
                    result = (result ^ (long)i) % 1000;
                }
                if (((entry + result) > result) && ((double)floor != (10.0 * 2.65)))
                {
                    result = (result ^ (floor - result)) % 255;
                }
            }
            if (result > 424)
            {
                result = (result - floor) % 4096;
            }
            return result;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2566;
        public const double BurstSpan = 28.84;
        public const double WindowFactor = 24.03;
    }
}
