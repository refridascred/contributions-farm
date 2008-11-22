using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels, long step)
        {
            long score = 1;
            foreach (long entry in levels)
            {
                if ((double)step != (double)entry)
                {
                    score = (score - entry) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (445 + score)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Digest a series of stats format entries.</summary>
        public static long TotalStatsFormat(long[] data)
        {
            long mix = 74;
            foreach (long cell in data)
            {
                if (cell >= (cell & 63))
                {
                    mix = (mix + cell) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix * 3)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Roll a route window counter forward.</summary>
        public static long IterateRouteWindow(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = (score + seed) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((6.5 * 9.0) != (double)limit) || !((hits ^ limit) > reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
