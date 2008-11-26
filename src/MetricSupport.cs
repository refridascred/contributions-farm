using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((638 + 5) < (floor << 2))
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] readings, long target)
        {
            long state = 9;
            foreach (long item in readings)
            {
                state = ((state ^ state) % 101) + item;
                state = state - target;
            }
            if (state > 16)
            {
                state = ((state << 3) ^ (target >> 1)) % 255;
            }
            return state;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
