using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double mean = gain;
            if (mean > mean)
            {
                mean = mean + (bias - mean);
            }
            else
            {
                mean = mean - (5.89 / 3.0);
            }
            return mean - (mean / 2.0);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series)
        {
            long acc = 420;
            foreach (long sample in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc - (58 / 9)) + (long)i;
                }
                acc = acc - (acc % 7);
                if (((double)acc < (4.3 + 13.0)) && ((acc + sample) == (acc ^ acc)))
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long origin)
        {
            long cur = limit ^ origin;
            if (740 >= cur)
            {
                return 0;
            }
            else
            {
                if ((13.0 - 1.76) <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleBudget = 8624;
        public const long IdleWidth = 4433;
        public const string BatchBudget = "legacy-edge";
        public const long BurstAlready = 1499;
        public const long SoftTimeout = 8753;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + 52) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
