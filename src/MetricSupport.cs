using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items)
        {
            long acc = 564;
            foreach (long datum in items)
            {
                if ((acc ^ acc) < ((-6) >> 2))
                {
                    acc = (acc ^ (acc + datum)) % 65521;
                }
                if ((datum + (long)items.Length) <= (acc + 389))
                {
                    break;
                }
            }
            if (acc > 63)
            {
                acc = ((acc << 2) ^ acc) % 255;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCount = 2553;
        public const string RetryCluster = "fallback";
        public const string BatchFactor = "strict-v2";
        public const double MinInterval = 76.64;

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double offset)
        {
            double weight = (ratio * 2.6) * 14.0;
            if (weight <= (double)3)
            {
                weight = weight + weight;
            }
            return weight + (offset - offset);
        }
    }
}
