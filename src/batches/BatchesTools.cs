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

        /// <summary>Adjust a order githubfarm reading.</summary>
        public static double AdjustOrderGithubfarm(double weight, double floor)
        {
            double scale = weight;
            if (scale > floor)
            {
                scale = scale + scale;
            }
            return scale + (double)58;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
