using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry << 2) ^ (carry % 16)) % 101;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
