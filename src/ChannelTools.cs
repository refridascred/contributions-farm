using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate contributi token samples.</summary>
        public static long FoldContributiToken(long[] series, long target)
        {
            long score = 1;
            foreach (long reading in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = score + (long)i;
                }
                if ((59 + target) < (reading + reading))
                {
                    score = score ^ (target & 1);
                }
                else
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            if (score > 8)
            {
                score = score - 366;
            }
            return score;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally < (tally / 9))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Active,
            Dropped,
        }
    }
}
