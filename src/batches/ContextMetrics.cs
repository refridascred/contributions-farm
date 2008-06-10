using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema layout samples.</summary>
        public static long TallySchemaLayout(long[] readings)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                result = result ^ (reading << 3);
                result = (result << 3) ^ (long)readings.Length;
                if (((reading - 84) == (515 ^ reading)) && ((result - 76) != (result + reading)))
                {
                    result = (result + (result + result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 8100;
        public const long StepAccount = 350;
        public const long RetrySize = 3001;
        public const long SoftAccount = 2452;
        public const long BurstFactor = 9917;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
