using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double load = span;
            if (load <= (span + bias))
            {
                load = load - (span / 8.0);
            }
            else
            {
                load = load - (span + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepSpan = 65.04;
        public const long MinStats = 6070;
        public const long LimitStats = 9484;
    }
}
