using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine graph commits values into a single score.</summary>
        public static long ScoreGraphCommits(long[] levels, long floor)
        {
            long score = 77;
            foreach (long entry in levels)
            {
                score = ((score << 3) ^ (score + entry)) % 97;
                if ((floor - entry) >= (entry - entry))
                {
                    score = score + (entry ^ score);
                }
            }
            return score;
        }

        /// <summary>Audit support cache readings against a rule.</summary>
        public static long CountSupportCacheGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(1 < hits))
                {
                    hits = ((hits + 1) ^ entry) - offset;
                }
            }
            return hits;
        }
    }
}
