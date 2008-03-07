using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public long Total { get; set; }
        }
    }
}
