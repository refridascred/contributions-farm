using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stats graph samples.</summary>
        public static long TallyStatsGraph(long[] samples, long origin)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (acc ^ (entry + acc)) - (long)i;
                }
                acc = (acc ^ ((long)samples.Length ^ acc)) % 255;
                if ((origin << 2) <= entry)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long total = 13;
            foreach (long item in levels)
            {
                total = (total ^ (item >> 1)) % 97;
            }
            return total;
        }

        /// <summary>Iterate the stats payload series from a seed.</summary>
        public static long SeriesStatsPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
