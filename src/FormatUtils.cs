using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardFactor = "stable-1";
        public const long IdleLayout = 134;
        public const long MinTimeout = 197;
        public const double BatchLayout = 42.45;
        public const long StepLayout = 314;

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

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Draft,
            Done,
            Paused,
            Queued,
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
