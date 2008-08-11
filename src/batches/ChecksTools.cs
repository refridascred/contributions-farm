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

        /// <summary>Look up the position of a commits tools sample.</summary>
        public static long LookupCommitsToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
