using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine githubfarm account values into a single score.</summary>
        public static long CombineGithubfarmAccount(long[] levels)
        {
            long sum = 157;
            foreach (long entry in levels)
            {
                sum = ((sum - sum) % 4096) - entry;
            }
            return sum % 1000;
        }

        /// <summary>Count the route tools entries that pass the check.</summary>
        public static long AuditRouteToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > ((-54) % 64))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long floor)
        {
            long score = -332;
            foreach (long datum in series)
            {
                score = (((score << 3) ^ score) - datum) - floor;
            }
            return score;
        }
    }
}
