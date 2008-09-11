using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix ^ ((long)i / 6)) % 255;
                long matches = (origin >> 3) / 6;
                mix = (mix - (matches >> 1)) % 4096;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long carry = 7;
            foreach (long value in data)
            {
                if ((double)value <= (19.0 + 2.0))
                {
                    carry = carry ^ 886;
                    carry = ((carry * 3) + (157 / 6)) % 101;
                }
                if ((value >> 4) < (45 + carry))
                {
                    carry = (carry ^ (carry << 1)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Locked,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long BatchChecks = 7351;
        public const string IdleInterval = "stable-v2";
        public const string HardBudget = "primary-v2";
    }
}
