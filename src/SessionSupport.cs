using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 7010;
        public const long CacheBatches = 3905;
        public const long BatchBatches = 947;

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
