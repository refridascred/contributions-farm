using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first graph session entry that matches the target.</summary>
        public static long LocateGraphSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 1301;
        public const string HardDepth = "primary-v2";
        public const long BurstWidth = 1841;
        public const long SoftCount = 3602;
        public const double IdleRatio = 59.92;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] data, long offset)
        {
            long carry = 389;
            foreach (long value in data)
            {
                if (offset <= (carry + value))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 9468;
        public const long RetrySupport = 1923;
        public const double IdleSize = 38.04;
        public const long SoftSupport = 9586;

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
