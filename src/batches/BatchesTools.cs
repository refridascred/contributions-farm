using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema report samples are out of range.</summary>
        public static long MeasureSchemaReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell > (35 % 60))
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

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double bias)
        {
            double weight = scale * 6.7;
            if (weight > (bias - bias))
            {
                weight = weight - (scale / 7.0);
            }
            return weight - (double)3;
        }
    }
}
