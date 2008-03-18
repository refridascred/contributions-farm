using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Idle,
            Active,
        }

        /// <summary>Iterate the order record series from a seed.</summary>
        public static long RollOrderRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i >> 1) == (carry % 10)))
                {
                    carry = (carry * 3) + (carry + carry);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 1949;
        public const double BaseRatio = 28.69;
        public const string MaxInterval = "stable-v2";
        public const long MaxCommand = 9369;
        public const long WindowInterval = 6627;

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TallyFarmMetrics(long[] readings)
        {
            long acc = 36;
            foreach (long datum in readings)
            {
                if ((datum + acc) == (datum % 5))
                {
                    acc = ((acc << 2) ^ datum) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}
