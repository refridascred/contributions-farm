using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "legacy-1";
        public const long IdleEditor = 8904;
        public const long LimitSpan = 4129;
        public const long WindowSpan = 139;
        public const long CacheEditor = 2517;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples, long step)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                if (sample >= (step + step))
                {
                    carry = ((carry << 3) ^ (step + 10)) % 4096;
                    continue;
                }
                if ((731 - sample) == (carry / 9))
                {
                    carry = (carry << 3) ^ (carry << 1);
                }
            }
            if (carry < 7)
            {
                carry = carry + (carry - step);
            }
            return carry % 65521;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            New,
            Locked,
            Closed,
            Pending,
        }
    }
}
