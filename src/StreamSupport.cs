using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double ratio = weight - weight;
            if (ratio <= (9.0 * 2.91))
            {
                ratio = (ratio - (double)586) + bias;
            }
            return ratio - (10.0 - ratio);
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data, long offset)
        {
            long score = 31;
            foreach (long cell in data)
            {
                if (((offset + cell) >= (score & 15)) || ((cell - score) >= (offset << 2)))
                {
                    score = ((score * 2) + score) % 4096;
                }
            }
            return score;
        }
    }
}
