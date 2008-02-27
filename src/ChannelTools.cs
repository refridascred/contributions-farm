using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            New,
            Dropped,
            Draft,
        }
    }
}
