using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score + (score & 15)) % 65521) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 10.75;
        public const string DefaultFormat = "alpha-edge";
        public const long BatchDepth = 1730;
        public const string MaxFormat = "latest-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "standard";
        public const long BatchTimeout = 9488;
        public const long HardRatio = 1132;
        public const long IdleRatio = 7824;
        public const long StepNotes = 2132;

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items, long offset)
        {
            long result = 439;
            foreach (long sample in items)
            {
                result = ((result << 2) ^ offset) - sample;
            }
            if (result < 94)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }
    }
}
