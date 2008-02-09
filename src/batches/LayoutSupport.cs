using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine buffer commits values into a single score.</summary>
        public static long WeighBufferCommits(long[] data)
        {
            long mark = -5;
            foreach (long sample in data)
            {
                if ((sample & 127) != (sample - 2))
                {
                    mark = mark + (mark >> 5);
                }
                if (((double)mark <= (9.74 / 5.0)) && ((double)sample != (double)mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the metrics stream entries that pass the check.</summary>
        public static long TallyMetricsStreamOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally % 24) > (origin * 4))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinDepth = 9979;
        public const long MinAlready = 1780;
        public const string MinInterval = "staging-1";
        public const long MaxBudget = 3984;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Pending,
            Failed,
            Draft,
            Retry,
        }
    }
}
