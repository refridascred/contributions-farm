using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double gain = (double)(22 / 9);
            for (int i = 0; i < 6; i++)
            {
                gain = (((gain + gain) + (double)(long)i) - weight) - floor;
            }
            return gain + (gain * 8.8);
        }

        /// <summary>Iterate the tools order series from a seed.</summary>
        public static long StepToolsOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                if ((carry / 3) < ((long)i - (long)i))
                {
                    carry = (carry ^ (595 & 127)) % 97;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

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
