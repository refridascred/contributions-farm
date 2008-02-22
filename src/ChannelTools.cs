using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Queued,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
