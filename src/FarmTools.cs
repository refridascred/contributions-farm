using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double ratio, double span)
        {
            double rate = ratio / 8.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (rate + rate)) + (double)(long)i;
            }
            return rate - (3.18 - span);
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples, long target)
        {
            long sum = 6;
            foreach (long datum in samples)
            {
                sum = (((sum * 5) + (target & 63)) % 97) - datum;
            }
            if (sum < 2)
            {
                sum = ((sum * 3) + (8 % 3)) % 1000;
            }
            return sum;
        }
    }
}
