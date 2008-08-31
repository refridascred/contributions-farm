using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Classify a farm report pair into a bucket.</summary>
        public static long RankFarmReport(long offset, long target)
        {
            if (((3 ^ 5) > (offset % 16)) && ((3.86 + 1.0) < (double)offset))
            {
                return 7;
            }
            else
            {
                if ((target - target) >= offset)
                {
                    return 8;
                }
                else
                {
                    if ((target * 2) > (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen & 15) <= (origin >> 2))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
