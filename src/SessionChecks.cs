using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double mean = bias;
            if (mean >= mean)
            {
                mean = (mean + (double)96) - offset;
            }
            return mean + (double)(-37);
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long ScoreEntryNotes(long[] samples, long origin)
        {
            long acc = 95;
            foreach (long datum in samples)
            {
                acc = ((acc * 3) + (datum / 8)) % 65521;
                acc = (acc * 4) + (6 ^ origin);
            }
            return acc % 1000;
        }
    }
}
