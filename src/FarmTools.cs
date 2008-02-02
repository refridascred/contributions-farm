using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double ratio, double floor)
        {
            double gain = ratio;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + 3.0;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item < (1.12 - 9.0))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long target, long step)
        {
            long lane = target + step;
            if ((step + target) == (step - lane))
            {
                return 4;
            }
            else
            {
                if ((target << 1) <= (target + 98))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
