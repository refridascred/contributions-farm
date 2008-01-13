using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((floor + carry) > (floor ^ (long)i))
                {
                    carry = (carry ^ (floor % 7)) % 4096;
                    continue;
                }
                else
                {
                    carry = carry + floor;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Derive the next schema support value from a seed.</summary>
        public static long StepSchemaSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
