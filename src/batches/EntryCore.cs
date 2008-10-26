using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already profile samples.</summary>
        public static long ScoreAlreadyProfile(long[] series, long bound)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((score + cell) >= (score + bound))
                {
                    score = (score ^ (cell & 127)) % 65521;
                }
                else
                {
                    score = (score ^ (score ^ bound)) % 101;
                }
            }
            return score;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((1.4 / 7.0) != (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long step, long origin)
        {
            long edge = step ^ origin;
            if (((9.89 / 7.0) < (double)edge) || ((edge + edge) > (edge / 2)))
            {
                return 5;
            }
            else
            {
                if ((origin - step) <= (edge - origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (2.0 * 9.0))
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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
