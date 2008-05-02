using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            New,
            Queued,
            Pending,
        }

        /// <summary>Look up the position of a checks channel sample.</summary>
        public static long FindChecksChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
