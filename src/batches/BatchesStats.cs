using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long floor, long limit)
        {
            long offset = floor - limit;
            if ((offset + floor) <= (offset - limit))
            {
                return 8;
            }
            else
            {
                if ((offset / 9) <= (offset % 10))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((9.6 - 6.9) == (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((origin << 1) > ((long)i >> 1)) || ((origin + mix) < ((long)i - origin)))
                {
                    mix = (mix << 2) ^ origin;
                }
                mix = (mix - (mix / 3)) % 255;
                mix = (mix ^ (mix / 4)) % 1000;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
