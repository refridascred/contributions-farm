using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (3.0 <= (double)sample)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double ratio = floor + (rate + floor);
            if (ratio >= floor)
            {
                ratio = ratio - (8.98 - floor);
            }
            return ratio + (floor + rate);
        }

        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long TallyEditorFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + tally) > (entry ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long floor)
        {
            if ((double)seed != (17.0 + 5.11))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((seed % 100) < (seed - seed)) || ((double)floor > (8.0 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed < floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate order batch readings against a bound.</summary>
        public static bool GuardOrderBatchBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a channel contributi reading by value.</summary>
        public static long FindChannelContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
