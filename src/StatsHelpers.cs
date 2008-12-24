using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = (total - total) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double offset)
        {
            double ratio = gain - gain;
            if (ratio >= (2.0 / 2.0))
            {
                ratio = ratio + (offset + 18.0);
            }
            else
            {
                ratio = ratio - (double)3;
            }
            return ratio - (ratio - gain);
        }
    }
}
