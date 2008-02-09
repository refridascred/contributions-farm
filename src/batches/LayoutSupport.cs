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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (bound < (tally ^ tally))
                {
                    tally = (tally + 3) - datum;
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
