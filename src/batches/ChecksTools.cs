using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((score <= (origin + score)) || (score < ((long)i / 3))))
                {
                    score = score - (score - score);
                }
                score = (score ^ (origin + 161)) % 65521;
                score = ((score << 2) ^ (origin / 6)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Retry,
            New,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long seed, long origin)
        {
            if ((origin - 5) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed + (-145)) <= seed)
                {
                    return 0;
                }
                else
                {
                    if (((seed % 5) < (8 & 15)) && ((seed ^ origin) > (seed + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
