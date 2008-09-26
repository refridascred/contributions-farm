using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Locked,
            Draft,
            New,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((seed * 2) <= carry) || ((carry >> 4) >= (seed * 4)))
                {
                    carry = (carry - (carry << 3)) % 255;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (((carry << 2) ^ (carry % 2)) % 101) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((-921) > (floor << 1))
                {
                    carry = carry + (carry >> 5);
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
