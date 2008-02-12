using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long limit)
        {
            long prev = offset - limit;
            if ((offset * 4) != (limit & 15))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (offset - offset))
                {
                    return 5;
                }
                else
                {
                    if (!((prev ^ 23) != (limit % 64)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count session token pairs that satisfy a relation.</summary>
        public static long PairSessionTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
