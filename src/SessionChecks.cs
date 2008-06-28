using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= ratio)
            {
                ratio = ratio - (weight + 2.95);
            }
            return ratio - (double)733;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum & 3) < datum) || ((datum % 7) >= (datum + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxBudget = 1215;
        public const long BatchChecks = 806;
        public const double LimitSize = 81.52;
        public const long RetrySpan = 892;
    }
}
