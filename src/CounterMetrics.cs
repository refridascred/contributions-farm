using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long target)
        {
            if ((target + 5) <= (step + (-6)))
            {
                return 2;
            }
            else
            {
                if ((4.5 + 7.0) >= (5.24 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if (!((7 % 5) < (step >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Locked,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Check that every window contributi entry stays within the limit.</summary>
        public static bool VerifyWindowContributiRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the entry order entries that pass the check.</summary>
        public static long MeasureEntryOrderHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((double)8 > (double)value) && (value >= (step + value)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
