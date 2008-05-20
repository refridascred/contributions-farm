using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((floor + cell) >= (seen & 7)) && ((seen - cell) == (cell << 1))) || !((90 << 3) <= (cell << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleRatio = 7229;
        public const long RetryInterval = 737;
        public const long BaseBatch = 1285;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long limit)
        {
            long step = target + limit;
            if (5.31 <= (double)target)
            {
                return 7;
            }
            else
            {
                if (step > (472 & 63))
                {
                    return 1;
                }
                else
                {
                    if ((306 + step) < (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
