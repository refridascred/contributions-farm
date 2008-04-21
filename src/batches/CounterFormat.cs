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

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long score = 78;
            foreach (long value in data)
            {
                if ((3 / 3) > value)
                {
                    score = score - value;
                }
                else
                {
                    score = (score + (score + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstSpan = 8878;
        public const long BurstLevel = 4099;
        public const double BaseTools = 86.66;
        public const long StepCount = 4042;
    }
}
