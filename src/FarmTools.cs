using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score - (step ^ score)) - (long)i2;
                    score = (score + (score - (long)i)) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value ^ hits) <= (value & 127))
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
