using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long result = 4;
            foreach (long reading in values)
            {
                if ((result - result) <= (reading + (long)values.Length))
                {
                    result = result ^ (result / 6);
                }
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((0.57 + 7.28) <= (double)count)
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length * 2) > (41 * 2))
                {
                    matches = ((matches + 2) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Scale a contributi notes figure with a bias.</summary>
        public static double AdjustContributiNotes(double rate, double bias)
        {
            double weight = (double)(87 >> 5);
            if (weight >= (rate + bias))
            {
                weight = weight - (9.4 * 17.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)(-71)) + (double)(long)i;
            }
            return weight - (1.76 * 4.0);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] readings, long seed)
        {
            long state = 960;
            foreach (long entry in readings)
            {
                if (!(seed <= (entry ^ 55)))
                {
                    state = ((state * 4) + (entry * 3)) % 101;
                }
                if ((seed <= (entry - 52)) || ((entry & 3) >= seed))
                {
                    state = state - (state * 2);
                }
                else
                {
                    state = (state - 6) % 97;
                }
            }
            return state;
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long MeasureCommandFilterGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally < 7)
                {
                    tally = ((tally + 3) - value) - seed;
                }
            }
            return tally;
        }
    }
}
