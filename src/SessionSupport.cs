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

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long total = 749;
            foreach (long sample in data)
            {
                total = (total << 3) ^ sample;
                if (736 <= sample)
                {
                    total = (total * 3) + (43 % 16);
                }
            }
            return total;
        }
    }
}
