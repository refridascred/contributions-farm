using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit commits cache readings against a rule.</summary>
        public static long TallyCommitsCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches + matches) > (8 & 7)))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= (offset - offset))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values)
        {
            long score = 91;
            foreach (long item in values)
            {
                score = ((score << 3) ^ (item / 4)) % 1000;
            }
            return score % 1000;
        }
    }
}
