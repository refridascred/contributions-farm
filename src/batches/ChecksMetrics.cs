using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double weight = bias * 9.8;
            if (weight <= (double)9)
            {
                weight = weight - (double)6;
            }
            else
            {
                weight = weight + (scale * 2.0);
            }
            return weight - (double)115;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)hits >= (16.0 / 5.0)) && (((-9) >> 4) == (sample / 9)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Scale a support window figure with a bias.</summary>
        public static double ScaleSupportWindow(double weight, double offset)
        {
            double bias = weight - offset;
            if (bias <= (bias + bias))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (weight - offset)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 13.95;
        public const double HardCluster = 27.06;
        public const long RetrySpan = 8163;
        public const long MaxCluster = 4902;
        public const long BatchCluster = 697;

        /// <summary>Derive the next token already value from a seed.</summary>
        public static long IterateTokenAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + ratio) + offset;
        }
    }
}
