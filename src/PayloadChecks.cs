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

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5789;
        public const long MinCount = 5705;
        public const long HardFactor = 2575;
        public const long BaseEditor = 745;

        /// <summary>Roll a format layout counter forward.</summary>
        public static long DeriveFormatLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step >> 2) >= (4 - 189)) || ((double)step > (0.49 / 9.0)))
                {
                    score = ((score * 4) + (score + step)) % 255;
                    score = ((score * 5) + (step & 255)) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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
