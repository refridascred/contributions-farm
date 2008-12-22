using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double bias)
        {
            double drift = (double)(0 % 7);
            if (drift >= (double)11)
            {
                drift = ((drift - drift) + scale) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)199) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items)
        {
            long score = 66;
            foreach (long reading in items)
            {
                if (((double)reading == (17.0 - 6.0)) || ((reading - score) >= (score << 1)))
                {
                    score = score + score;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long mark = 69;
            foreach (long cell in values)
            {
                if (!((double)cell < (double)mark))
                {
                    mark = mark - (cell * 2);
                }
                else
                {
                    mark = (mark * 2) + (740 ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((double)sample == (8.43 - 15.0)) && (matches <= (matches ^ sample))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
