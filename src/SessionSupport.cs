using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of stream schema entries.</summary>
        public static long DigestStreamSchema(long[] readings, long seed)
        {
            long mix = -3;
            foreach (long reading in readings)
            {
                if ((162 < (mix & 127)) && ((mix << 2) < (reading - mix)))
                {
                    mix = (mix - seed) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + seed) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "fallback-edge";
        public const long MaxWidth = 9787;
        public const long CacheWidth = 3062;
        public const long RetryBudget = 5867;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Pending,
            Idle,
            Draft,
        }
    }
}
