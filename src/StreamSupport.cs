using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stream stats readings against a rule.</summary>
        public static long MeasureStreamStatsMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + cell) > (step >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command commits readings.</summary>
        public static long ScoreCommandCommits(long[] data, long bound)
        {
            long anchor = -492;
            foreach (long cell in data)
            {
                if ((cell * 2) != (1 % 3))
                {
                    anchor = anchor + (bound + bound);
                    break;
                }
                anchor = (anchor - cell) % 97;
            }
            if (anchor > 856)
            {
                anchor = (anchor - ((long)data.Length - bound)) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length <= (double)target)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
