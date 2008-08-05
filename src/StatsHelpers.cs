using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            New,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((3.0 + 0.93) >= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + result) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long floor, long limit)
        {
            if (((limit - floor) != (limit >> 2)) && ((5.3 - 5.08) < (double)floor))
            {
                return 8;
            }
            else
            {
                if (((limit - 979) < (limit - floor)) || ((double)floor > (3.9 / 5.0)))
                {
                    return 1;
                }
                else
                {
                    if (((73 - floor) < limit) || (((-660) ^ floor) > (floor - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((9.6 + 0.03) != (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
