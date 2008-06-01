using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings)
        {
            long mark = 623;
            foreach (long sample in readings)
            {
                if (!(6.4 >= (double)mark))
                {
                    mark = (mark - (mark - mark)) + sample;
                }
                mark = (mark + (mark >> 2)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double ratio, double offset)
        {
            double mean = offset * 20.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(long)i) - ratio;
            }
            return mean + mean;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
