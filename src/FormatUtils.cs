using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long step)
        {
            long carry = -2;
            foreach (long item in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry << 2) ^ (carry % 100)) % 65521) ^ (long)i;
                }
                carry = (carry * 5) + (step % 12);
                if ((double)carry == (double)item)
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = (carry + step) % 97;
                }
            }
            if (carry < 439)
            {
                carry = (carry - (carry - step)) % 4096;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSize = 197;
        public const long SoftBudget = 9087;
        public const long RetryScore = 4451;
        public const long HardDepth = 7237;

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor * 5) + (856 + origin)) % 65521) ^ (long)i2;
                }
                if ((double)(long)i == (8.08 / 5.0))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    long hits = (long)i;
                    anchor = anchor ^ (hits * 3);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 37.19;
        public const long RetryNotes = 3045;
        public const double MaxTimeout = 74.39;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Stale,
            Active,
        }
    }
}
