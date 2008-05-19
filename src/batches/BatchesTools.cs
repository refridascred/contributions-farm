using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheFactor = 4704;
        public const long MaxAlready = 8345;
        public const long MinAlready = 3252;
        public const double DefaultAlready = 72.13;

        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long RankOrderContributi(long seed, long bound)
        {
            long next = seed - bound;
            if ((next << 3) > 54)
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (2.4 + 19.0))
                {
                    return 6;
                }
                else
                {
                    if ((next >> 5) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound < (seed + 396))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
