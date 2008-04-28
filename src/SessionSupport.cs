using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long target2)
        {
            if ((target <= (target2 - target)) && ((target ^ target2) >= target))
            {
                return 6;
            }
            else
            {
                if (((double)target2 != (20.0 + 9.0)) || (target < (target / 6)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (origin * 4)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
