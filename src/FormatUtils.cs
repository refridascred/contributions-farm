using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a contributi cache sample.</summary>
        public static long LookupContributiCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items, long bound)
        {
            long mark = 63;
            foreach (long item in items)
            {
                mark = mark - (mark - (long)items.Length);
                if (((mark + item) == (740 + bound)) && (bound < (56 + mark)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double gain = bias * 3.25;
            if (gain < offset)
            {
                gain = gain + (bias + bias);
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (bias * 8.67);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardSpan = 97.15;
        public const long BurstSize = 7738;
        public const long StepInterval = 9710;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((5.04 / 9.0) < (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((tally < sample) && ((sample - tally) <= (limit >> 4))) && ((limit + 553) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
