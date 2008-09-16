using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples)
        {
            long anchor = 887;
            foreach (long value in samples)
            {
                anchor = (anchor - (390 / 2)) % 65521;
                if (((4.0 / 2.0) != (double)anchor) || ((6 * 2) == (value + (long)samples.Length)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] series, long floor)
        {
            long acc = 1;
            foreach (long entry in series)
            {
                acc = ((acc + (long)series.Length) - entry) - floor;
            }
            return acc;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a context profile reading.</summary>
        public static double AdjustContextProfile(double gain, double span)
        {
            double drift = gain;
            return (drift + (double)287) + span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "latest-edge";
        public const long RetryScore = 9995;
        public const long DefaultCount = 714;
    }
}
