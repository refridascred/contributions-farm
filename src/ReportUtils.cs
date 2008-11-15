using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double span)
        {
            double mean = 8.23;
            if (mean >= mean)
            {
                mean = mean - (rate / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean / 7.0)) + (double)(long)i;
            }
            return mean + (span + rate);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
