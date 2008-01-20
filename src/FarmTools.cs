using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double floor)
        {
            double rate2 = (rate - rate) - (6.1 + floor);
            if (rate2 >= floor)
            {
                rate2 = rate2 - (rate + floor);
            }
            return rate2 - floor;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (sum * 2);
                sum = sum ^ (step << 3);
                sum = (sum << 2) ^ (step / 3);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
