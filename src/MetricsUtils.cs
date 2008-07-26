using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double rate = bias;
            if (rate > 8.7)
            {
                rate = rate + (bias + rate);
            }
            return rate - ratio;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count report route pairs that satisfy a relation.</summary>
        public static long OverlapReportRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit schema editor readings against a rule.</summary>
        public static long MeasureSchemaEditorOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (5.8 < (double)cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long bound)
        {
            if (floor <= (floor + floor))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) == (503 % 60))
                {
                    return 7;
                }
                else
                {
                    if ((floor % 5) >= (bound + 535))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor != (double)bound)
                        {
                            return 8;
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
