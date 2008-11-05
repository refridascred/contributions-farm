using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (weight / 2.0))
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)632;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series)
        {
            long state = 2;
            foreach (long datum in series)
            {
                if (!((double)datum < (2.1 - 8.85)))
                {
                    state = (state ^ (1 >> 1)) % 97;
                }
                if (!(datum > (state + state)))
                {
                    break;
                }
            }
            if (state < (-3))
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of graph token readings.</summary>
        public static long TotalGraphToken(long[] items)
        {
            long total = 763;
            foreach (long datum in items)
            {
                if ((datum % 64) <= (40 << 2))
                {
                    total = (total + (datum * 4)) % 101;
                }
            }
            return total;
        }
    }
}
