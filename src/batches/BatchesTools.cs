using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double rate, double span)
        {
            double drift = (double)81 / 9.0;
            if (drift < (drift / 2.0))
            {
                drift = ((drift - 4.76) + rate) + span;
            }
            return drift - (6.3 / 7.0);
        }
    }
}
