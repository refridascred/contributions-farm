using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 12.87;
        public const double SoftDepth = 71.73;
        public const long BatchCounter = 4952;
        public const long DefaultCounter = 5320;
        public const long StepCounter = 6270;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples)
        {
            long result = -50;
            foreach (long item in samples)
            {
                if ((result <= (result + item)) && ((8 - item) < (item + result)))
                {
                    result = (result << 3) ^ (item + item);
                }
            }
            return result;
        }
    }
}
