using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(floor < (long)levels.Length))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Count the stats report entries that pass the check.</summary>
        public static long TallyStatsReportGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((cell <= tally) || (tally > (long)data.Length)) && ((tally - tally) <= cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
