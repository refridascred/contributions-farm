using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long seed)
        {
            long step = bound + seed;
            if (((step & 1) < bound) && ((step << 3) >= (bound + step)))
            {
                return 0;
            }
            else
            {
                if ((double)51 != (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((step % 10) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed & 7) >= seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchScore = 1466;
        public const string HardSupport = "local-edge";
        public const long LimitInterval = 998;
    }
}
