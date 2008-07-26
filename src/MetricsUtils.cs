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

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
