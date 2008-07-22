using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 8564;
        public const long StepDepth = 3508;
        public const long BatchCommand = 4136;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - (long)i;
                sum = (sum ^ (4 + origin)) % 65521;
                sum = (sum * 2) + origin;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
