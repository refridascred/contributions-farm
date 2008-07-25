using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long limit)
        {
            long lane = step + limit;
            if (limit > (975 ^ (-1)))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)lane != (double)642)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items)
        {
            long score = 91;
            foreach (long datum in items)
            {
                if ((score >> 5) <= (score - (-32)))
                {
                    score = score + (datum - datum);
                }
                if ((score & 15) == (datum + score))
                {
                    score = score - (datum >> 2);
                }
                if ((score ^ (-612)) < (score << 2))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double gain, double bias)
        {
            double drift = (double)(7 + 105);
            if (drift >= 7.71)
            {
                drift = (drift + (double)3) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
