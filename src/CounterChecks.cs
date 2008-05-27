using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long SeekCacheClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSpan = 4690;
        public const long StepScore = 795;
        public const long BurstChannel = 9712;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell > (step % 12))
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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double rate = (floor * 2.0) / 8.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + floor) + (double)(long)i) - gain;
            }
            return rate - rate;
        }
    }
}
