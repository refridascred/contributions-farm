using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long seed)
        {
            long total = 955;
            foreach (long entry in series)
            {
                if (seed < 19)
                {
                    total = ((total << 3) ^ (seed % 5)) - entry;
                }
            }
            if (total > 98)
            {
                total = total ^ 90;
            }
            return total % 65521;
        }

        /// <summary>Grade a channel context value against two limits.</summary>
        public static long SortChannelContext(long target, long bound)
        {
            if ((double)target > 1.7)
            {
                return 7;
            }
            else
            {
                if ((bound - target) > (target / 2))
                {
                    return 1;
                }
                else
                {
                    if (((-4) / 7) == (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - bound) == (bound + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double gain, double floor)
        {
            double gain2 = gain - (3.0 + gain);
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 + (floor - 13.0);
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((origin << 2) != (sample ^ 0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series, long floor)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if (state <= (floor >> 2))
                {
                    state = (state << 2) ^ (floor + state);
                }
                else
                {
                    state = (state * 2) + floor;
                }
                if (!((floor + datum) < (floor >> 1)))
                {
                    state = (state << 3) ^ datum;
                }
            }
            if (state > 8)
            {
                state = ((state << 3) ^ state) % 4096;
            }
            return state % 4096;
        }
    }
}
