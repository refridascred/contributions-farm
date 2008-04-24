using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLevel = 1911;
        public const double SoftWidth = 93.1;
        public const long CacheLayout = 1038;
        public const long CacheFactor = 4273;

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchScore = 3.93;
        public const long SoftOrder = 7246;
        public const double LimitOrder = 88.46;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long offset, long origin)
        {
            long gap = offset + origin;
            if (offset >= 23)
            {
                return 5;
            }
            else
            {
                if (((-18) % 60) < origin)
                {
                    return 7;
                }
                else
                {
                    if (gap >= (gap ^ gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
