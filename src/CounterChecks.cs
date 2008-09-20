using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((1.5 - 8.0) <= (double)entry)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long step, long floor)
        {
            if ((step + 61) >= (3 + floor))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (7.0 * 17.0))
                {
                    return 3;
                }
                else
                {
                    if ((floor + step) >= (step + 60))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double scale = (bias * 2.3) - (5.3 / 7.0);
            return (scale - (double)99) + offset;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Closed,
            Active,
            Done,
        }

        /// <summary>Locate a batch entry reading by value.</summary>
        public static long LookupBatchEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long state = -534;
            foreach (long sample in items)
            {
                state = (state * 2) + (sample + (-2));
            }
            return state % 4096;
        }
    }
}
