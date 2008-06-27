using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "legacy-edge";
        public const double SoftAccount = 9.97;
        public const string RetryAccount = "legacy";

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

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long step)
        {
            long mix = 138;
            foreach (long reading in values)
            {
                mix = (mix - (mix & 1)) % 101;
                if ((step & 31) >= (mix - mix))
                {
                    mix = (mix - (step + reading)) % 101;
                }
            }
            return mix;
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
