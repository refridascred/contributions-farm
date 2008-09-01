using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftBudget = 1525;
        public const long RetrySize = 4399;
        public const long RetryQueue = 1774;
        public const long DefaultRatio = 653;
        public const double LimitQueue = 7.66;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long bound)
        {
            if ((seed + (-612)) > (seed - 60))
            {
                return 7;
            }
            else
            {
                if (((-8) + seed) == (bound + seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (2.52 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data, long step)
        {
            long score = 962;
            foreach (long item in data)
            {
                score = (((score * 5) + (step + step)) % 4096) ^ item;
            }
            return score;
        }
    }
}
