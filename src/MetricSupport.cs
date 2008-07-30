using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the schema format series from a seed.</summary>
        public static long RollSchemaFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (carry >> 4);
                if (floor <= ((long)i * 2))
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
                carry = ((carry << 3) ^ (long)i) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
