using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Retry,
            New,
        }

        /// <summary>Count the editor channel entries that pass the check.</summary>
        public static long MeasureEditorChannelGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((214 & 3) != (seen - seen))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a editor cluster reading by value.</summary>
        public static long LocateEditorClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
