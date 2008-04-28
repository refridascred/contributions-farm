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

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Idle,
            Pending,
            Retry,
            Queued,
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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + target) + (long)i2;
                }
                if ((target > ((long)i ^ (long)i)) && ((double)target > (double)mix))
                {
                    mix = ((mix << 2) ^ (mix / 7)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
