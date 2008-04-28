using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double mean = floor - rate;
            if (mean < (double)161)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (floor - mean);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (9.02 - mean)) + (double)(long)i;
            }
            return mean - (floor + 4.5);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long total = 894;
            foreach (long entry in readings)
            {
                if ((entry - entry) > (total + 5))
                {
                    total = (total << 3) ^ (entry >> 3);
                }
                else
                {
                    total = (total + total) % 101;
                }
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total + total);
            }
            return total % 97;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
