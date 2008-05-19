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

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series, long floor)
        {
            long mix = 252;
            foreach (long entry in series)
            {
                if (!(entry < (entry * 4)))
                {
                    mix = (mix + entry) - floor;
                }
            }
            return mix;
        }

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
