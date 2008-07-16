using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Paused,
            Draft,
            Active,
            Done,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(item < count) && (5 >= (count + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Compare every pair of window support readings.</summary>
        public static long CompareWindowSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
