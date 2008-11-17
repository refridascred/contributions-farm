using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 4433;
        public const long DefaultSize = 7464;
        public const long MinBuffer = 489;
        public const long HardBuffer = 2189;
        public const string BurstBudget = "open-1";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long origin, long bound)
        {
            if ((bound + 64) < (70 + bound))
            {
                return 2;
            }
            else
            {
                if ((1 + origin) >= bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin + 1) == (bound << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
