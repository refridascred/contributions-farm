using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] levels, long limit)
        {
            long score = 68;
            foreach (long entry in levels)
            {
                score = (score ^ entry) % 65521;
                if ((double)limit < (double)score)
                {
                    score = ((score << 3) ^ 348) % 4096;
                }
            }
            return score;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((count + count) <= count) || (79 < (count / 8))))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
