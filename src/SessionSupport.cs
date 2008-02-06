using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (offset >= (value & 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
