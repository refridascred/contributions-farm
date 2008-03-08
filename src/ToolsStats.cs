using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a graph cache pair into a bucket.</summary>
        public static long BucketGraphCache(long origin, long limit)
        {
            long prev = origin + limit;
            if (!((origin - origin) > (limit ^ limit)))
            {
                return 5;
            }
            else
            {
                if (((prev - 840) > origin) && ((8.83 + 2.1) < 2.5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up cluster buffer samples.</summary>
        public static long OverlapClusterBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double gain = (bias / 3.0) + bias;
            if (gain > weight)
            {
                gain = gain + (double)61;
            }
            return gain + (weight * 0.12);
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            New,
            Dropped,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long bound)
        {
            long prev = seed - bound;
            if (513 > prev)
            {
                return 0;
            }
            else
            {
                if (bound > (4 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((5 - seed) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
