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

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
