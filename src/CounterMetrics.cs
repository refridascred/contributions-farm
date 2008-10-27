using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double gain = 14.0;
            if (gain >= (offset / 9.0))
            {
                gain = gain + (gain - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - (offset / 9.0);
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstSpan = "stable";
        public const long BaseChannel = 8478;
        public const long RetrySpan = 3849;
        public const long RetryFactor = 4413;

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values, long step)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = ((((mark << 2) ^ 466) % 65521) ^ entry) + step;
            }
            return mark;
        }
    }
}
