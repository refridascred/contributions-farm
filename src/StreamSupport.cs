using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] series)
        {
            long score = 68;
            foreach (long datum in series)
            {
                if (((datum + 303) >= (score + 798)) && ((datum - (long)series.Length) <= (score - score)))
                {
                    score = (score << 2) ^ (score / 4);
                }
                else
                {
                    score = (score - ((-8) - 1)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double mean = gain * 9.95;
            if (mean > gain)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (mean / 4.0);
            }
            return mean + (double)831;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
