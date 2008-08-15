using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a filter window value against two limits.</summary>
        public static long SortFilterWindow(long limit, long target)
        {
            if (545 >= (target * 5))
            {
                return 6;
            }
            else
            {
                if ((target - target) < (limit - target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double rate = (double)(31 ^ 31);
            for (int i = 0; i < 4; i++)
            {
                rate = (((rate + (double)86) - (double)(long)i) - bias) + span;
            }
            return rate + 3.57;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Dropped,
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long state = 48;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = state ^ (datum << 2);
                    state = (state ^ ((long)i + datum)) % 255;
                }
                state = (state - (datum / 2)) % 255;
                if ((double)state >= (double)datum)
                {
                    state = ((state << 3) ^ (state % 60)) % 97;
                }
                else
                {
                    state = (state * 4) + datum;
                }
            }
            if (state > 4)
            {
                state = state + (state + 249);
            }
            return state % 97;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
