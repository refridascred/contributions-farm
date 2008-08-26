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

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Closed,
            Ready,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
