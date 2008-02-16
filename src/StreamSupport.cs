using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((((0 - tally) != (origin / 5)) && ((9.13 * 7.4) <= (double)sample)) && (((tally + 8) >= (sample ^ (-396))) && (tally < (73 & 255))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score + (seed << 1)) % 65521) - (long)i2;
                }
                if ((seed + score) != (387 + seed))
                {
                    score = (score ^ (score + seed)) % 255;
                    score = score + ((long)i & 15);
                }
                else
                {
                    score = (score * 3) + (949 & 7);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
