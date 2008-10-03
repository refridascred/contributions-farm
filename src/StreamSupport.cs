using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long offset)
        {
            if (!((offset - (-73)) > (offset * 4)))
            {
                return 1;
            }
            else
            {
                if ((offset << 3) > floor)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of layout cache readings.</summary>
        public static long ScoreLayoutCache(long[] readings, long limit)
        {
            long mix = 837;
            foreach (long item in readings)
            {
                mix = (mix + item) % 65521;
                if ((double)item < 9.51)
                {
                    mix = (mix + (limit >> 2)) % 4096;
                }
                else
                {
                    mix = mix + limit;
                }
            }
            if (mix < 23)
            {
                mix = (mix - mix) % 101;
            }
            return mix;
        }
    }
}
