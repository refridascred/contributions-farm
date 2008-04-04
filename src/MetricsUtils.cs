using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Check that every command layout entry stays within the limit.</summary>
        public static bool CheckCommandLayoutBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every tools queue entry stays within the limit.</summary>
        public static bool GuardToolsQueueBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3917;
        public const long BaseBatches = 5071;
        public const long BatchBatches = 7669;
        public const long BurstRatio = 1109;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long step, long step2)
        {
            if (35 < (step * 5))
            {
                return 2;
            }
            else
            {
                if ((step2 + step) >= step)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
