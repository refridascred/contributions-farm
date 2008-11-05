using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Fold a list of entry layout readings.</summary>
        public static long CombineEntryLayout(long[] samples, long step)
        {
            long anchor = 83;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor + (cell + anchor)) % 255) - (long)i) - step;
                }
                if (((long)samples.Length - cell) != (anchor >> 5))
                {
                    anchor = ((anchor << 2) ^ (76 / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the cluster commits entries that pass the check.</summary>
        public static long TallyClusterCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) < (hits + cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
