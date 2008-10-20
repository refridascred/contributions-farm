using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two record command measurements.</summary>
        public static double AdjustRecordCommand(double rate, double bias)
        {
            double mean = (double)(69 * 5);
            if (mean > bias)
            {
                mean = (mean + (bias / 7.0)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)4) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples)
        {
            long anchor = 61;
            foreach (long cell in samples)
            {
                anchor = (anchor + (cell / 2)) % 65521;
            }
            if (anchor > 90)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
