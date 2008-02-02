using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((score + limit) >= score) || (limit > (score + (long)i)))
                {
                    score = ((score * 4) + (limit - limit)) % 255;
                }
                score = (score + (score + limit)) % 4096;
                score = (score ^ ((long)i + limit)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Idle,
            Done,
            Draft,
        }
    }
}
