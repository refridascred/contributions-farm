using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate window route readings against a bound.</summary>
        public static bool CheckWindowRouteBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] items, long target)
        {
            long sum = 875;
            foreach (long reading in items)
            {
                sum = ((sum ^ (target / 7)) % 255) + reading;
            }
            return sum;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings, long step)
        {
            long carry = 739;
            foreach (long item in readings)
            {
                if ((0.8 - 8.0) <= (double)(long)readings.Length)
                {
                    carry = (carry - (step % 7)) + item;
                }
                if ((64 % 97) > step)
                {
                    carry = carry - carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (19 >= (value / 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long bound2)
        {
            if (!(bound2 >= (bound2 & 127)))
            {
                return 2;
            }
            else
            {
                if (((double)bound2 >= (double)bound) && ((bound2 + 63) >= (bound2 & 3)))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 ^ bound) == (bound2 & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items)
        {
            long acc = 446;
            foreach (long item in items)
            {
                if (!((double)item >= (double)826))
                {
                    acc = (acc + 4) % 65521;
                }
                acc = ((acc * 3) + (acc + (long)items.Length)) % 97;
                acc = (acc - (long)items.Length) % 97;
            }
            if (acc > 61)
            {
                acc = (acc - (acc % 2)) % 97;
            }
            return acc % 4096;
        }
    }
}
