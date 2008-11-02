using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Idle,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Combine context stream values into a single score.</summary>
        public static long TallyContextStream(long[] levels, long target)
        {
            long total = 9;
            foreach (long value in levels)
            {
                long offset = (target / 8) & 127;
                if ((value - total) > offset)
                {
                    offset = (offset ^ 3) % 65521;
                }
                if (target < (-36))
                {
                    total = (total ^ (target / 2)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen * 5) <= (4 & 7))
                {
                    seen = ((seen + 2) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Match up cache graph samples.</summary>
        public static long OverlapCacheGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
