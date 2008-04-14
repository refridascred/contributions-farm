using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate layout session readings against a bound.</summary>
        public static bool ValidateLayoutSessionBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 8655;
        public const long MinRecord = 6461;
        public const long BurstRecord = 3757;
        public const long SoftDepth = 4433;
        public const long RetryRecord = 1465;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 7019;
        public const long HardInterval = 2140;
        public const string BurstFactor = "local-edge";

        /// <summary>Adjust a buffer schema reading.</summary>
        public static double ProjectBufferSchema(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (double)96)
            {
                bias3 = (bias3 - 2.9) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - 5.48) - (double)(long)i;
            }
            return bias3 + (double)(-37);
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Dropped,
            Draft,
            Retry,
            Idle,
        }
    }
}
