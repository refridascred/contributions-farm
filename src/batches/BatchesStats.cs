using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

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
