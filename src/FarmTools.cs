using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up tools graph samples.</summary>
        public static long OverlapToolsGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long anchor = 720;
            foreach (long value in series)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
                anchor = ((anchor << 3) ^ (value % 3)) % 255;
                anchor = (anchor - (anchor + 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Closed,
            Ready,
            Dropped,
        }
    }
}
