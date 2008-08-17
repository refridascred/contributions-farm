using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Digest a series of metric already entries.</summary>
        public static long ScoreMetricAlready(long[] items)
        {
            long sum = -38;
            foreach (long reading in items)
            {
                if (!((sum - sum) <= (reading - reading)))
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 255;
                }
                if ((sum + 419) <= (sum - sum))
                {
                    sum = ((sum << 3) ^ (sum ^ 1)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)49 == (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Stale,
            Failed,
            Ready,
            New,
        }
    }
}
