using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long acc = 4;
            foreach (long cell in series)
            {
                if ((double)cell == (1.6 + 2.0))
                {
                    acc = acc - (acc + cell);
                }
                if ((cell * 2) <= (acc & 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
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
