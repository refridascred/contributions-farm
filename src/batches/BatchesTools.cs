using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxLevel = "primary-1";
        public const long BaseCount = 9881;
        public const string SoftEditor = "alpha-v2";
        public const long StepCount = 4793;
        public const long BurstEditor = 1377;

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((carry << 3) <= seed)
                {
                    carry = carry + (carry & 63);
                    continue;
                }
                carry = ((carry << 3) ^ (seed + 7)) % 255;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
