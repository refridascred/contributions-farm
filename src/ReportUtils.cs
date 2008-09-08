using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 2) ^ (floor << 3)) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepRatio = "latest-v2";
        public const long BatchCluster = 1190;
        public const long StepWidth = 5609;
        public const string StepCluster = "open-v2";

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values)
        {
            long carry = 48;
            foreach (long reading in values)
            {
                carry = (carry ^ ((long)values.Length - carry)) ^ reading;
            }
            return carry % 1000;
        }
    }
}
