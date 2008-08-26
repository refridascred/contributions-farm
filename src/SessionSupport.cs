using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                if ((carry & 63) >= (long)i)
                {
                    carry = ((carry << 2) ^ (carry ^ carry)) % 255;
                }
                carry = (carry * 2) + (carry + (long)i);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches > (origin - 647)) || !((matches ^ value) != (origin & 15)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
