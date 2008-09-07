using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values)
        {
            long mix = 2;
            foreach (long value in values)
            {
                mix = ((mix + (mix - (long)values.Length)) % 97) - value;
            }
            return mix;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1170;
        public const long IdleBudget = 1483;
        public const long BaseInterval = 6929;
        public const long WindowWidth = 8295;
    }
}
