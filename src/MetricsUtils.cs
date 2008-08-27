using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = (score + (score % 8)) % 255;
                if (!(((long)i % 2) <= (long)i))
                {
                    score = ((score << 3) ^ ((long)i % 16)) % 101;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            long step = origin + floor;
            if ((step / 3) < 80)
            {
                return 0;
            }
            else
            {
                if (floor >= (origin - step))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((seed > cell) && ((seed / 9) < (-8)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
