using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((511 + reading) >= 5) || (limit >= (9 - reading)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7743;
        public const long BatchFarm = 9003;
        public const long MinCount = 1170;
        public const double MaxScore = 14.23;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long seed)
        {
            long step = floor ^ seed;
            if ((2.7 + 0.12) > (double)step)
            {
                return 0;
            }
            else
            {
                if ((((-96) % 60) >= (floor * 5)) && (step < (2 ^ floor)))
                {
                    return 5;
                }
                else
                {
                    if (((step / 8) == (step << 1)) || ((step / 3) > (2 << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((10.0 + 7.0) > (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Retry,
            Ready,
            Paused,
            Queued,
        }
    }
}
