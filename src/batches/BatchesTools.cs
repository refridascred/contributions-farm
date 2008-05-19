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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((acc / 4) != ((-984) + limit))
                {
                    acc = (acc + 81) % 255;
                    break;
                }
                acc = (acc ^ limit) % 1000;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
