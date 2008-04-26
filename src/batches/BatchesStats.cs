using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next already window value.</summary>
        public static double BlendAlreadyWindow(double weight, double offset)
        {
            double load = (double)((-331) % 97);
            if (load < weight)
            {
                load = (load + weight) + offset;
            }
            return load - (double)65;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Retry,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double rate = weight;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + (weight / 7.0)) + (double)(long)i) - bias;
            }
            return rate - rate;
        }
    }
}
