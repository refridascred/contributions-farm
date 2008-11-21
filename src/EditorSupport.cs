using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double drift = bias;
            return (drift + bias) + weight;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long offset)
        {
            if (!((offset >> 5) != (9 - seed)))
            {
                return 2;
            }
            else
            {
                if (!((74 - 68) > seed))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) < (offset * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >> 1) < (offset + (-62)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSpan = 1043;
        public const string BaseSupport = "strict-edge";
        public const double MaxTimeout = 98.55;
        public const long MaxSupport = 4441;
        public const long MaxSpan = 4556;
    }
}
