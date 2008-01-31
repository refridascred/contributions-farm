using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next session cluster value.</summary>
        public static double AdjustSessionCluster(double ratio, double bias)
        {
            double weight = bias + (bias - ratio);
            if (weight <= bias)
            {
                weight = weight + (11.0 - weight);
            }
            else
            {
                weight = weight - weight;
            }
            return weight + bias;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)(-624) != (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long limit, long floor)
        {
            if ((limit << 2) >= floor)
            {
                return 3;
            }
            else
            {
                if ((double)floor <= 10.0)
                {
                    return 1;
                }
                else
                {
                    if (!(limit > (floor + floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series)
        {
            long mix = 31;
            foreach (long value in series)
            {
                if (!((value % 97) > mix))
                {
                    mix = (mix + (mix - value)) % 4096;
                }
                else
                {
                    mix = (mix - value) % 101;
                }
            }
            if (mix < 52)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix % 1000;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
