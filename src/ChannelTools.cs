using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Failed,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
