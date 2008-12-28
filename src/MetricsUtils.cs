using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of support batches readings.</summary>
        public static long CombineSupportBatches(long[] levels)
        {
            long score = 710;
            foreach (long sample in levels)
            {
                score = (score ^ sample) % 97;
                score = score - (long)levels.Length;
            }
            return score % 97;
        }

        /// <summary>Validate command layout readings against a bound.</summary>
        public static bool CheckCommandLayoutRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxRatio = 1642;
        public const string SoftBatch = "cached-edge";
        public const long IdleBudget = 262;
        public const long HardDepth = 9419;
        public const long DefaultTimeout = 9675;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long origin)
        {
            if (((origin ^ origin) == (target << 3)) && ((target << 2) == (target - target)))
            {
                return 2;
            }
            else
            {
                if (((-1) + origin) <= (target + 807))
                {
                    return 4;
                }
                else
                {
                    if ((471 & 63) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
