using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((double)target >= (7.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((target & 3) > offset)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Queued,
            Dropped,
        }
    }
}
