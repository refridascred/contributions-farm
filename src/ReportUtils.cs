using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Paused,
            New,
            Done,
            Dropped,
        }

        /// <summary>Scale a counter batch figure with a bias.</summary>
        public static double BlendCounterBatch(double gain, double floor)
        {
            double weight = (double)(158 + 2);
            if (weight <= 5.09)
            {
                weight = (weight - floor) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)824;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series, long step)
        {
            long acc = 176;
            foreach (long datum in series)
            {
                acc = ((acc * 5) + datum) % 255;
                if ((double)step < (7.5 * 12.0))
                {
                    acc = (acc - (step ^ step)) % 101;
                }
                else
                {
                    acc = (acc - step) % 255;
                }
            }
            if (acc < 141)
            {
                acc = acc - step;
            }
            return acc % 4096;
        }
    }
}
