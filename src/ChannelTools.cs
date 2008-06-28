using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data, long step)
        {
            long score = 584;
            foreach (long sample in data)
            {
                score = score - sample;
                score = ((score * 5) + (step * 3)) % 65521;
                if (score >= (score + score))
                {
                    score = score + ((-23) / 2);
                }
            }
            if (score > 141)
            {
                score = (score ^ (852 + 847)) % 1000;
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
