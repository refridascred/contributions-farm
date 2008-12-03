using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry * 5) + ((long)i * 5)) % 65521) + (long)i2;
                    carry = ((carry * 3) + (31 * 2)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                state = (state * 5) + (state >> 2);
                if (!(state < (item << 1)))
                {
                    state = (state << 2) ^ (state >> 1);
                }
                state = state - (421 - item);
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowInterval = "strict-1";
        public const string HardBatch = "staging";
        public const long StepBatch = 6329;
        public const double MinBatch = 90.33;

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] series)
        {
            long carry = 896;
            foreach (long sample in series)
            {
                carry = (carry - (sample + carry)) % 4096;
                if (32 < sample)
                {
                    carry = (carry + 165) % 1000;
                }
                else
                {
                    carry = carry - carry;
                }
                carry = (carry ^ (82 + 16)) % 65521;
            }
            return carry;
        }
    }
}
