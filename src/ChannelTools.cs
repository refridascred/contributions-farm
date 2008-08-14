using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepSize = 88.69;
        public const double BatchWindow = 12.54;
        public const double MaxWindow = 22.82;
        public const long IdleFactor = 4534;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a cache batch pair into a bucket.</summary>
        public static long RankCacheBatch(long limit, long seed)
        {
            if ((seed + limit) > (seed / 5))
            {
                return 7;
            }
            else
            {
                if ((double)52 < (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (double)506)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit != (5.19 * 0.92))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
