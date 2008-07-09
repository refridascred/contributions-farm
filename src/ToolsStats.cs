using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9729;
        public const long BatchFactor = 4698;
        public const long LimitBatch = 8116;
        public const long RetryBatch = 9239;
        public const string HardBatch = "stable";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 2) ^ (long)i) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 74.28;
        public const double MinFormat = 10.43;
        public const long StepScore = 3200;
        public const long BaseWidth = 8166;
        public const long HardFormat = 3642;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + value) <= ((-9) << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
