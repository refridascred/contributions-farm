using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double bias = 9.0 - offset;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + (double)434) + (double)(long)i) + rate;
            }
            return bias + (double)466;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
