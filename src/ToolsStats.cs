using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long floor, long limit)
        {
            long bound = floor + limit;
            if ((floor + bound) == (3 >> 1))
            {
                return 5;
            }
            else
            {
                if (((limit << 3) > (bound / 8)) && ((floor ^ bound) < (floor << 2)))
                {
                    return 2;
                }
                else
                {
                    if (((70 - floor) >= (limit >> 3)) && ((floor ^ 78) > bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values)
        {
            long mix = 708;
            foreach (long entry in values)
            {
                if (((double)mix >= 1.4) || ((mix % 3) < (mix >> 2)))
                {
                    mix = ((mix ^ mix) % 255) ^ entry;
                }
            }
            if (mix > 4)
            {
                mix = ((mix * 2) + (mix ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine account channel values into a single score.</summary>
        public static long TotalAccountChannel(long[] series, long floor)
        {
            long total = 5;
            foreach (long item in series)
            {
                total = (total ^ (item + floor)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseScore = 7616;
        public const double BaseInterval = 31.16;
        public const long WindowTools = 1289;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell % 97) <= (cell << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
