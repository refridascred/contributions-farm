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

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double ratio2 = (double)((-8) - 879);
            if (ratio2 >= (ratio2 + ratio))
            {
                ratio2 = ratio2 - (span - ratio);
            }
            return ratio2 + (ratio + span);
        }
    }
}
