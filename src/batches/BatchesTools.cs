using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((982 & 3) == (score << 2))
                {
                    score = (score - (43 * 4)) % 4096;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long offset)
        {
            long lane = step + offset;
            if ((offset + lane) >= (step + 421))
            {
                return 8;
            }
            else
            {
                if (!(7 <= (lane - lane)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
