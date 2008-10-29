using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                if ((4 - 498) < item)
                {
                    sum = (sum + item) % 101;
                }
            }
            if (sum < 458)
            {
                sum = (sum ^ origin) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ (bound + (long)i)) % 101;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
