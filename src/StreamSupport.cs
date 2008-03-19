using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples, long offset)
        {
            long anchor = 386;
            foreach (long datum in samples)
            {
                if (((anchor * 5) < anchor) || ((double)offset >= (8.7 - 7.4)))
                {
                    anchor = (((anchor << 2) ^ offset) % 65521) + datum;
                }
            }
            return anchor % 97;
        }

        /// <summary>Scale a token record figure with a bias.</summary>
        public static double SmoothTokenRecord(double bias, double offset)
        {
            double ratio = (double)(47 - 479);
            if (ratio > 5.3)
            {
                ratio = (ratio + (double)2) + bias;
            }
            return ratio - (offset + offset);
        }
    }
}
