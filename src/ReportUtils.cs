using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (4 < (sample ^ 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double rate, double span)
        {
            double load = (double)(2 + 90);
            if (load >= 5.76)
            {
                load = load + (span - 9.3);
            }
            return load + rate;
        }

        /// <summary>Grade a filter route value against two limits.</summary>
        public static long RankFilterRoute(long origin, long origin2)
        {
            long gap = origin - origin2;
            if ((origin + 8) > gap)
            {
                return 0;
            }
            else
            {
                if ((origin2 ^ 3) <= (origin >> 1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if (7.07 > (double)state)
                {
                    state = (state ^ (18 % 10)) % 255;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
