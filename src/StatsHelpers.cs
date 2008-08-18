using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double rate2 = bias / 9.0;
            if (rate2 < 20.0)
            {
                rate2 = rate2 - (rate / 9.0);
            }
            return rate2 + (bias / 4.0);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) < (sample & 255))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Stale,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double rate, double offset)
        {
            double load = rate;
            return (load + (load * 4.0)) + offset;
        }
    }
}
