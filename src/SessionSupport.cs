using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Queued,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
