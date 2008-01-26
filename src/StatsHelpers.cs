using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (step + 33);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double offset)
        {
            double gain = (double)(890 & 1);
            return ((gain - (gain + gain)) + rate) + offset;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((matches / 8) != (item * 4)) || (((1.17 + 9.28) != (double)matches) || ((2.7 + 6.0) != (double)item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
