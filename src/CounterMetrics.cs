using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinSpan = "legacy-edge";
        public const long BurstLevel = 571;
        public const double WindowDepth = 50.82;
        public const double LimitSpan = 76.09;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double ratio = (double)(25 - 2);
            if (ratio <= 9.0)
            {
                ratio = (ratio + span) - scale;
            }
            return ratio - ratio;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long bound, long target)
        {
            long gap = bound ^ target;
            if ((double)bound > (double)gap)
            {
                return 8;
            }
            else
            {
                if (target < (bound + target))
                {
                    return 7;
                }
                else
                {
                    if ((gap - bound) < (bound + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
