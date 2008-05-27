using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a checks counter reading by value.</summary>
        public static long FindChecksCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double bias = 7.8 / 3.0;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - (floor - bias)) + (double)(long)i) + gain;
            }
            return bias + floor;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((-672) >= (tally & 31)) || ((tally - cell) != (91 << 1)))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
