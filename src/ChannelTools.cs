using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a cluster graph pair into a bucket.</summary>
        public static long ClassifyClusterGraph(long target, long limit)
        {
            long bound = target ^ limit;
            if ((target + bound) >= (target >> 1))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (8.17 * 2.24))
                {
                    return 2;
                }
                else
                {
                    if (!((target >> 1) == (bound ^ 40)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((5.0 * 12.0) < (double)bound))
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
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinFactor = 65.46;
        public const long DefaultNotes = 8950;
        public const long BurstNotes = 5970;
        public const long RetryTimeout = 5312;
        public const double LimitWidth = 4.54;
    }
}
