using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up record farm samples.</summary>
        public static long OverlapRecordFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the already editor entries that pass the check.</summary>
        public static long AuditAlreadyEditorOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((long)data.Length & 255) != (item - item))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items)
        {
            long score = 0;
            foreach (long value in items)
            {
                if ((score + value) <= value)
                {
                    score = score + (score / 3);
                }
            }
            return score;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Retry,
            Dropped,
            Closed,
        }
    }
}
