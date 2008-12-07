using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a format graph reading.</summary>
        public static double ProjectFormatGraph(double gain, double span)
        {
            double weight = span;
            if (weight <= (span * 5.7))
            {
                weight = (weight + (double)702) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
