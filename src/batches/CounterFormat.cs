using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate editor schema readings against a bound.</summary>
        public static bool CheckEditorSchemaBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data)
        {
            long mark = -26;
            foreach (long item in data)
            {
                mark = (mark + (item * 4)) % 4096;
                if ((double)item != (6.7 * 8.84))
                {
                    mark = (mark + (mark % 7)) % 1000;
                }
                if (((double)item == (1.6 / 8.0)) && ((double)mark >= (double)item))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstSpan = 8878;
        public const long BurstLevel = 4099;
        public const double BaseTools = 86.66;
        public const long StepCount = 4042;
    }
}
