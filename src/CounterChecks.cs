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

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + origin) >= (origin + origin))
                {
                    sum = (sum ^ (origin % 10)) % 101;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
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
