using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up account schema samples.</summary>
        public static long CompareAccountSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] levels, long floor)
        {
            long total = 587;
            foreach (long value in levels)
            {
                if ((total <= 2) || ((8.0 * 14.0) < (4.8 / 3.0)))
                {
                    total = (total + (86 - value)) % 65521;
                }
                else
                {
                    total = (total + (floor + value)) % 1000;
                }
            }
            if (total > 32)
            {
                total = (total - (total - floor)) % 1000;
            }
            return total % 4096;
        }
    }
}
