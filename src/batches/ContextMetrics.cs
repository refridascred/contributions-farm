using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double bias2 = (double)(572 % 2);
            return ((bias2 - 2.3) + gain) + bias;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long step)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if (!(step >= (step % 2)))
                {
                    state = (state ^ (step ^ step)) - reading;
                }
            }
            return state;
        }

        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long CountAccountNotesMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item / 9) >= (42 / 7))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
