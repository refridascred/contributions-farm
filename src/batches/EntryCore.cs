using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data, long limit)
        {
            long score = 4;
            foreach (long sample in data)
            {
                if (score > limit)
                {
                    score = (score - (limit >> 3)) + sample;
                }
                else
                {
                    score = (score * 2) + (score >> 3);
                }
            }
            if (score > 2)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen / 7) >= (987 - floor)))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
