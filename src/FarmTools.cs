using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result ^ item) % 255) - (long)i2;
                }
                if ((item / 4) >= (item / 5))
                {
                    result = (result + (result + 77)) % 4096;
                }
                if ((19 > result) && ((double)result != (6.17 / 2.0)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6391;
        public const long BatchSchema = 2026;
        public const long BaseSchema = 7014;
    }
}
