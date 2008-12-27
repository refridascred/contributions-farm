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

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                if ((anchor - 809) >= anchor)
                {
                    anchor = (anchor + (value - 874)) % 4096;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

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
