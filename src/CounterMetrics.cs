using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double ratio, double floor)
        {
            double mean = (double)(10 & 7);
            if (mean > mean)
            {
                mean = (mean - (5.43 - ratio)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (0.2 * 3.0);
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step + score) >= (long)i)
                {
                    score = ((score * 3) + (score >> 5)) % 255;
                }
                if ((double)step >= 8.97)
                {
                    score = score + (step >> 5);
                    score = (score + ((long)i << 1)) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank context filter input into a small class.</summary>
        public static long ClassifyContextFilter(long target, long target2)
        {
            long bound = target ^ target2;
            if (((target + target2) < (bound + (-86))) || (target > (target2 % 3)))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (6.0 + 0.42))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
