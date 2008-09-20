using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long target, long target2)
        {
            long offset = target - target2;
            if ((target2 ^ offset) <= (target2 & 15))
            {
                return 0;
            }
            else
            {
                if ((1.62 / 2.0) < (double)target2)
                {
                    return 4;
                }
                else
                {
                    if (!((7.0 + 1.44) > (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double rate, double floor)
        {
            double load = floor / 9.0;
            if (load < 6.0)
            {
                load = load - (rate + load);
            }
            return load + rate;
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
