using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long seed, long bound)
        {
            long diff = seed - bound;
            if (((seed + diff) >= (seed & 127)) && (17.0 < (double)diff))
            {
                return 3;
            }
            else
            {
                if (5 >= (bound & 31))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double gain = (double)6 / 9.0;
            if (gain >= (offset + ratio))
            {
                gain = gain + (ratio / 3.0);
            }
            return gain + (gain - ratio);
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the githubfarm entry entries that pass the check.</summary>
        public static long CountGithubfarmEntryOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((83 <= (5 + matches)) && ((84 / 9) <= (matches >> 4))) || ((1 + cell) >= (matches % 10)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
