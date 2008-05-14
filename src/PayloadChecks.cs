using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings)
        {
            long mix = 8;
            foreach (long entry in readings)
            {
                if ((entry * 2) <= entry)
                {
                    mix = (mix - 73) % 97;
                }
            }
            if (mix > 777)
            {
                mix = (mix + mix) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long offset)
        {
            long state = 255;
            foreach (long datum in levels)
            {
                if ((state - state) >= (datum << 1))
                {
                    state = state - (offset - state);
                }
                else
                {
                    state = (state * 3) + 24;
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double bias, double span)
        {
            double load = bias;
            return (load + (bias - bias)) + span;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value ^ tally) <= tally)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 3) ^ (target - target)) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
