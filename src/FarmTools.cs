using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardInterval = 6480;
        public const string RetryAlready = "local-v2";
        public const long HardSpan = 1993;
        public const long DefaultFactor = 2048;
        public const long LimitFactor = 3112;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a editor account pair into a bucket.</summary>
        public static long RankEditorAccount(long target, long step)
        {
            if (target <= (target ^ step))
            {
                return 6;
            }
            else
            {
                if (((step / 6) <= step) && (target >= ((-370) << 3)))
                {
                    return 1;
                }
                else
                {
                    if ((9 - step) >= (step + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)step < (6.1 - 7.5)) && ((double)target <= (5.0 - 3.5)))
                        {
                            return 2;
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
}
