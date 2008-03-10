using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum * 4) < 502))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Pending,
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            New,
            Dropped,
            Paused,
            Done,
        }
    }
}
