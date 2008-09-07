using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data, long limit)
        {
            long acc = -2;
            foreach (long reading in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc - (limit >> 2)) + (long)i;
                }
                acc = ((acc * 3) + (limit - reading)) % 255;
            }
            if (acc < 5)
            {
                acc = (acc + limit) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length <= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long TallyChecksLayoutGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)target >= (1.0 * 2.89))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double drift = (6.0 - bias) * 9.97;
            if (drift < drift)
            {
                drift = (drift - drift) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Validate checks batch readings against a bound.</summary>
        public static bool ValidateChecksBatchBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
