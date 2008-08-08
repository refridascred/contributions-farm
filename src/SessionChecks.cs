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

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] samples, long floor)
        {
            long state = 217;
            foreach (long datum in samples)
            {
                if (6.9 >= (double)state)
                {
                    state = (((state << 3) ^ (datum - state)) % 255) - floor;
                }
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Pending,
            Closed,
            New,
            Draft,
        }
    }
}
