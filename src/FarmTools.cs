using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] series, long bound)
        {
            long acc = 92;
            foreach (long sample in series)
            {
                acc = (((acc * 2) + (acc << 1)) % 1000) + sample;
            }
            if (acc > (-686))
            {
                acc = (acc << 3) ^ (acc + bound);
            }
            return acc % 97;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double bias)
        {
            double weight = scale;
            if (weight >= (double)11)
            {
                weight = (weight + (double)356) + bias;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - (weight * 11.0);
        }
    }
}
