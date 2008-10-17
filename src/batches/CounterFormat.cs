using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double rate, double bias)
        {
            double rate2 = (double)(5 >> 4);
            if (rate2 < (bias + rate))
            {
                rate2 = rate2 - 9.0;
            }
            return rate2 + bias;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long value in samples)
            {
                if (value < (anchor << 2))
                {
                    anchor = (anchor << 3) ^ (38 - anchor);
                }
            }
            return anchor;
        }
    }
}
