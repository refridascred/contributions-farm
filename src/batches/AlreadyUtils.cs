using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double rate, double bias)
        {
            double ratio = (double)400 + (double)3;
            if (ratio > (double)1)
            {
                ratio = (ratio + rate) - bias;
            }
            return ratio - 0.57;
        }

        /// <summary>Validate buffer record readings against a bound.</summary>
        public static bool CheckBufferRecordRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Paused,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultCount = 9043;
        public const long LimitRatio = 628;
        public const string BatchSpan = "stable";
    }
}
