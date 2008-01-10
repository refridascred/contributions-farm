using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            New,
            Retry,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long seed)
        {
            long step = limit - seed;
            if (((seed - 4) < 478) || ((7.0 / 7.0) == (double)limit))
            {
                return 1;
            }
            else
            {
                if ((step + seed) != (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if (((step + seed) >= (seed * 4)) || ((9.1 / 4.0) < (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
