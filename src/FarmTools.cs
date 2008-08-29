using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long target)
        {
            if ((floor + floor) != (target >> 3))
            {
                return 8;
            }
            else
            {
                if (floor > (25 - 0))
                {
                    return 0;
                }
                else
                {
                    if ((floor + target) >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + target) != (target + 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
