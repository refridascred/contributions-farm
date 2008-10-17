using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Match up farm support samples.</summary>
        public static long OverlapFarmSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
