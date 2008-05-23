using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            New,
            Locked,
            Failed,
        }

        /// <summary>Count the graph token entries that pass the check.</summary>
        public static long TallyGraphTokenOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry + offset) != (offset & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Stale,
            Failed,
        }
    }
}
