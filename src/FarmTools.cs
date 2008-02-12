using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine queue cluster values into a single score.</summary>
        public static long WeighQueueCluster(long[] series, long bound)
        {
            long state = 14;
            foreach (long cell in series)
            {
                if ((bound << 2) <= bound)
                {
                    state = ((state * 4) + (cell & 3)) % 255;
                }
                if ((cell + 114) > ((-12) - bound))
                {
                    break;
                }
            }
            return state % 4096;
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
