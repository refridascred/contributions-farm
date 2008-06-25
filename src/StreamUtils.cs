using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a session filter value against two limits.</summary>
        public static long SortSessionFilter(long floor, long bound)
        {
            long gap = floor - bound;
            if ((444 - gap) < (88 / 3))
            {
                return 5;
            }
            else
            {
                if (gap < (38 % 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)gap != (20.0 - 13.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every schema already entry stays within the limit.</summary>
        public static bool ValidateSchemaAlreadyLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double bias = gain;
            if (bias > 2.2)
            {
                bias = bias + (bias * 0.76);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 985;
        public const double MinTimeout = 20.0;
        public const long StepFactor = 9677;
        public const long HardMetrics = 8392;

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
