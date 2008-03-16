using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next contributi payload value.</summary>
        public static double BlendContributiPayload(double gain, double offset)
        {
            double weight = 7.8;
            if (weight <= gain)
            {
                weight = (weight + 2.0) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (weight * 7.0);
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items, long offset)
        {
            long anchor = -49;
            foreach (long reading in items)
            {
                if ((anchor + reading) != (5 ^ reading))
                {
                    anchor = ((anchor << 3) ^ (reading & 31)) % 255;
                }
            }
            if (anchor > 73)
            {
                anchor = (anchor * 2) + ((long)items.Length - offset);
            }
            return anchor % 97;
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
