using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstInterval = 81.86;
        public const long BatchLevel = 3370;
        public const long DefaultMetric = 1452;
        public const string StepMetric = "latest";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (13.0 - 2.0))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            long cur = seed + floor;
            if (cur > (floor << 2))
            {
                return 5;
            }
            else
            {
                if (6 > (seed / 3))
                {
                    return 7;
                }
                else
                {
                    if (!(7.07 < (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((2.67 - 9.0) < (double)cur) || ((80 ^ (-5)) >= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public double Score { get; set; }
        }
    }
}
