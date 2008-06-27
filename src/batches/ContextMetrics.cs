using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Retry,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double bias, double span)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = (mean + bias) - span;
            }
            return mean + (11.0 - bias);
        }

        /// <summary>Roll a buffer schema counter forward.</summary>
        public static long IterateBufferSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + 31) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many report metric samples are out of range.</summary>
        public static long MeasureReportMetricMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((entry + 46) < (entry % 100)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
