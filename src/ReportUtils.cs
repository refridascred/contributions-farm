using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Done,
            Active,
            Stale,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up entry farm samples.</summary>
        public static long OverlapEntryFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!!((double)datum < (6.98 / 9.0)))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Paused,
            Done,
            Locked,
        }
    }
}
