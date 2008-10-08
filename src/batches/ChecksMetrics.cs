using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)mark != (4.38 - 9.0))
                {
                    mark = (mark + ((long)i & 63)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultScore = 878;
        public const string RetrySession = "alpha-edge";
        public const string SoftSize = "fallback-1";
        public const double WindowSession = 29.91;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "local-v2";
        public const double DefaultInterval = 97.65;
        public const double BurstFilter = 43.67;
        public const long MaxRatio = 1817;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((cell >= (69 << 3)) || ((1.1 - 3.24) <= (1.7 + 4.0))) && ((origin & 3) > cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Retry,
            Idle,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Locked,
            Stale,
            Active,
            Idle,
        }
    }
}
