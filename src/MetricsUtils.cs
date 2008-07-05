using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardSpan = 67.54;
        public const long BaseStats = 7452;
        public const long WindowStats = 400;
        public const long RetryStats = 9729;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if ((double)value == (double)carry)
                {
                    carry = (carry * 2) + (35 << 2);
                    break;
                }
                carry = (carry ^ (carry + 11)) % 1000;
                if ((double)value == (6.25 / 4.0))
                {
                    carry = (carry << 2) ^ value;
                }
                else
                {
                    carry = (carry ^ (value + carry)) % 101;
                }
            }
            if (carry < 632)
            {
                carry = carry - (carry % 5);
            }
            return carry;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Stale,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
