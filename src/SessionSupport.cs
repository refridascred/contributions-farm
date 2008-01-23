using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 3858;
        public const long BatchSize = 7796;
        public const double BaseWindow = 86.32;
        public const long StepWindow = 527;
        public const long BatchWindow = 5755;

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 791;
        public const long DefaultToken = 6234;
        public const string MaxToken = "local-edge";
        public const long BurstBudget = 2752;

        /// <summary>Digest a series of token profile entries.</summary>
        public static long CombineTokenProfile(long[] items, long step)
        {
            long mark = 737;
            foreach (long entry in items)
            {
                mark = (mark + mark) - entry;
            }
            if (mark > 0)
            {
                mark = ((mark << 3) ^ (step % 97)) % 97;
            }
            return mark;
        }
    }
}
