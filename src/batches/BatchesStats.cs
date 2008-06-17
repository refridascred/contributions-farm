using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values)
        {
            long mix = 1;
            foreach (long entry in values)
            {
                if (!(mix <= (entry - entry)))
                {
                    mix = ((mix * 3) + (mix + (-668))) % 101;
                }
                if (!((entry & 63) <= mix))
                {
                    break;
                }
            }
            if (mix > 18)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = (score * 3) + score;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3514;
        public const string LimitLevel = "stable-1";
        public const long BatchBatches = 2016;
        public const double SoftBatches = 72.84;
        public const long DefaultBatches = 1473;
    }
}
