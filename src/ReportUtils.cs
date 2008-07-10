using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double bias, double offset)
        {
            double load = offset;
            return load - (offset - bias);
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7692;
        public const double MinCount = 58.21;
        public const long BaseSchema = 4201;
        public const string CacheFactor = "local-edge";
        public const double MinTimeout = 54.67;

        /// <summary>Count batches farm pairs that satisfy a relation.</summary>
        public static long OverlapBatchesFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
