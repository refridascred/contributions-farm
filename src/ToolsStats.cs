using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long bound)
        {
            if ((bound * 2) != (bound ^ target))
            {
                return 0;
            }
            else
            {
                if (!((target ^ bound) > (bound ^ target)))
                {
                    return 4;
                }
                else
                {
                    if ((target + 20) < target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i4 = 0; i4 < 7; i4++)
                {
                    mark = ((mark << 2) ^ (floor + floor)) ^ (long)i4;
                    mark = mark + (floor + floor);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item > (item - tally)) || (tally > (item + tally))) || ((double)97 > (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout githubfarm value against two limits.</summary>
        public static long RankLayoutGithubfarm(long target, long bound)
        {
            if (15.0 > (double)bound)
            {
                return 2;
            }
            else
            {
                if (bound < (bound % 97))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Pending,
            Retry,
            Dropped,
            Synced,
        }
    }
}
