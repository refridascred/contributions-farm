using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long CountWindowLayoutMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value & 15) >= hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardWidth = 7655;
        public const string DefaultDepth = "stable-1";
        public const long MaxCount = 1168;
        public const long SoftChecks = 8524;

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
