using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (origin > (sample / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
