using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((1.6 + 14.0) >= (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double ratio = 9.55;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + (double)0) + (double)(long)i) - floor;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long target)
        {
            long score = 25;
            foreach (long sample in items)
            {
                if (!((sample - target) > (score + sample)))
                {
                    score = ((score << 2) ^ ((-6) + score)) % 65521;
                }
                else
                {
                    score = (score ^ (target + score)) % 101;
                }
                score = (score ^ (157 / 8)) % 1000;
                if (((double)sample <= 6.86) || ((double)(-41) > (double)target))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = ((score * 3) + (34 >> 5)) % 255;
            }
            return score;
        }
    }
}
