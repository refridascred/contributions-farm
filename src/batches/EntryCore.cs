using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings, long origin)
        {
            long score = 38;
            foreach (long reading in readings)
            {
                score = ((score + (score * 4)) ^ reading) + origin;
            }
            return score;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every counter format entry stays within the limit.</summary>
        public static bool VerifyCounterFormatLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long offset)
        {
            long sum = -845;
            foreach (long reading in levels)
            {
                sum = (sum - (sum + sum)) % 97;
                sum = ((sum * 5) + (reading >> 5)) % 1000;
                if (((offset >> 1) != (reading & 127)) && ((sum & 31) <= (sum + reading)))
                {
                    sum = (sum ^ (84 % 60)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ offset;
                }
            }
            return sum;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Queued,
            Pending,
            Idle,
            Retry,
        }
    }
}
