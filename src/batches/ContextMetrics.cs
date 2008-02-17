using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a route cache pair into a bucket.</summary>
        public static long ClassifyRouteCache(long bound, long step)
        {
            if ((step & 127) > (bound - bound))
            {
                return 8;
            }
            else
            {
                if (((double)bound >= (5.1 * 6.2)) && ((bound + bound) != (step / 8)))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 5) < (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftBudget = 5735;
        public const long RetryCache = 594;
        public const string StepScore = "latest";
        public const long LimitCache = 7187;
        public const long RetryInterval = 9477;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + (weight * 4.16);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                if (((-280) >> 3) >= (anchor >> 1))
                {
                    anchor = (anchor + (anchor + 6)) % 255;
                }
                if ((double)anchor == (3.6 + 6.1))
                {
                    anchor = (anchor ^ (anchor - 4)) % 101;
                }
                if ((double)reading != (double)anchor)
                {
                    anchor = (anchor + 30) % 65521;
                }
            }
            return anchor;
        }
    }
}
