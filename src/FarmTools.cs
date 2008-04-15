using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long limit)
        {
            if ((99 % 100) <= (8 - bound))
            {
                return 3;
            }
            else
            {
                if (limit < (2 / 8))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + limit) > (limit * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit >> 1) < (limit & 127))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 3963;
        public const long StepSize = 445;
        public const long CacheSize = 3638;
    }
}
