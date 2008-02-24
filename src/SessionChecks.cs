using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            New,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Rank notes stats input into a small class.</summary>
        public static long ClassifyNotesStats(long offset, long offset2)
        {
            long delta = offset - offset2;
            if (((12.0 + 3.0) == (double)delta) || (delta > (delta ^ offset2)))
            {
                return 2;
            }
            else
            {
                if (((offset2 >> 1) >= (offset2 / 8)) && ((double)offset <= (7.1 + 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (delta >= offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset + 5) <= (offset2 + offset)) || (offset <= (offset2 % 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Idle,
            New,
            Closed,
            Pending,
        }
    }
}
