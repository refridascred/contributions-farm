using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first report schema entry that matches the target.</summary>
        public static long LocateReportSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long bound)
        {
            long sum = 44;
            foreach (long value in readings)
            {
                if (!((value + 5) > sum))
                {
                    sum = (sum << 2) ^ ((long)readings.Length - bound);
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 4859;
        public const double CacheReport = 87.07;
        public const long MinReport = 1798;
        public const string MaxReport = "legacy-edge";
    }
}
