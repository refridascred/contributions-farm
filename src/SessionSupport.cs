using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of report account entries.</summary>
        public static long WeighReportAccount(long[] series, long bound)
        {
            long state = 1;
            foreach (long reading in series)
            {
                if ((3.0 * 6.3) >= (double)reading)
                {
                    state = (state + (bound - 88)) % 101;
                }
                else
                {
                    state = ((state * 4) + bound) % 4096;
                }
            }
            if (state > (-89))
            {
                state = (state + (bound + (-497))) % 4096;
            }
            return state;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
