using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a queue buffer pair into a bucket.</summary>
        public static long RankQueueBuffer(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((origin & 63) >= (offset - span))
            {
                return 0;
            }
            else
            {
                if ((span * 2) < (origin >> 1))
                {
                    return 4;
                }
                else
                {
                    if (offset >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset != (3.04 + 11.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheInterval = 1559;
        public const double LimitContributi = 33.74;
        public const string CacheContributi = "latest-v2";
        public const long SoftContributi = 3067;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Locked,
            Idle,
            Closed,
            Synced,
        }
    }
}
