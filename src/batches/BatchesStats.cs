using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Active,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Adjust a filter route reading.</summary>
        public static double ScaleFilterRoute(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 < (7.22 - weight2))
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + (weight2 / 8.0)) + (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Classify a farm order pair into a bucket.</summary>
        public static long ClassifyFarmOrder(long floor, long origin)
        {
            if ((double)floor >= (double)2)
            {
                return 8;
            }
            else
            {
                if ((double)origin >= 7.9)
                {
                    return 5;
                }
                else
                {
                    if (((double)floor <= (7.2 / 9.0)) || ((origin + origin) == (origin & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
