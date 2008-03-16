using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] samples, long step)
        {
            long mix = 92;
            foreach (long reading in samples)
            {
                long offset = mix;
                if (((offset >> 2) >= (mix & 1)) && (9.1 > (double)reading))
                {
                    mix = ((mix ^ (reading & 15)) % 97) - step;
                }
                else
                {
                    offset = ((offset * 5) + (reading - 2)) % 1000;
                }
                mix = mix ^ (long)samples.Length;
            }
            return mix;
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

        /// <summary>Rank record contributi input into a small class.</summary>
        public static long ClassifyRecordContributi(long offset, long step)
        {
            if ((offset << 2) < (step * 2))
            {
                return 2;
            }
            else
            {
                if ((double)step < 5.6)
                {
                    return 8;
                }
                else
                {
                    if ((step * 5) > (offset - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every farm editor entry stays within the limit.</summary>
        public static bool GuardFarmEditorRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
