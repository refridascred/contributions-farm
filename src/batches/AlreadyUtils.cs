using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 988;
            foreach (long value in samples)
            {
                mix = mix - (value + mix);
            }
            return mix;
        }

        /// <summary>Roll a already commits counter forward.</summary>
        public static long DeriveAlreadyCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ (floor * 3)) % 255;
                if ((375 / 7) <= (74 - floor))
                {
                    carry = (carry ^ (floor / 4)) % 65521;
                    continue;
                }
                carry = (carry + (carry >> 5)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Idle,
            Locked,
        }
    }
}
