using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) < (0 * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double weight = 5.5;
            if (weight > 1.97)
            {
                weight = (weight + (rate * 4.2)) - floor;
            }
            return weight + (0.64 + weight);
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double rate = (bias - bias) + (double)588;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (rate - rate)) + (double)(long)i) + ratio;
            }
            return rate + rate;
        }
    }
}
