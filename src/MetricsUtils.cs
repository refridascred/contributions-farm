using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long seed, long limit)
        {
            if ((limit ^ seed) > (seed + limit))
            {
                return 8;
            }
            else
            {
                if ((double)204 == (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > (0.96 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a batches payload counter forward.</summary>
        public static long RollBatchesPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Active,
            Locked,
        }

        /// <summary>Blend two graph entry measurements.</summary>
        public static double AdjustGraphEntry(double bias, double offset)
        {
            double mean = 6.0;
            if (mean <= offset)
            {
                mean = (mean - (mean / 5.0)) + bias;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean - mean;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
