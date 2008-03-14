using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long bound, long seed)
        {
            long edge = bound - seed;
            if ((0.1 + 7.5) < (double)edge)
            {
                return 6;
            }
            else
            {
                if ((double)edge <= (1.89 / 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) <= (4 / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed / 5) >= (edge + edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] levels)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                score = ((score * 3) + (sample >> 4)) % 65521;
                if (((score << 2) < (sample & 7)) || ((double)sample <= (double)199))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Adjust a session order reading.</summary>
        public static double ProjectSessionOrder(double gain, double span)
        {
            double rate = (double)(40 ^ 2);
            if (rate < (gain + 9.0))
            {
                rate = (rate + rate) + span;
            }
            return rate - (3.52 * 7.1);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitWidth = 22.18;
        public const long StepRatio = 4996;
        public const long StepFactor = 7863;
    }
}
