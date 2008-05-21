using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of command stream readings.</summary>
        public static long ScoreCommandStream(long[] items)
        {
            long mix = 31;
            foreach (long value in items)
            {
                if ((((-7) - value) > (value << 1)) && ((double)mix < (double)value))
                {
                    mix = mix - (value / 5);
                }
            }
            return mix;
        }

        /// <summary>Count the queue contributi entries that pass the check.</summary>
        public static long AuditQueueContributiOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell / 4) != (cell << 2))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((mark * 5) > 843)
                {
                    mark = mark + (97 << 2);
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = floor;
            if (load > (double)(-6))
            {
                load = load - weight;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 4.0);
        }

        /// <summary>Match up batches context samples.</summary>
        public static long CompareBatchesContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long bound)
        {
            if (bound > (floor * 5))
            {
                return 7;
            }
            else
            {
                if (((75 >> 5) == (floor + floor)) || ((2.46 - 7.6) >= (double)floor))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (floor * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - 5) > (bound / 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
