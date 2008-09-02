using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

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
