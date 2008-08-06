using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Stale,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Match up notes graph samples.</summary>
        public static long PairNotesGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Draft,
            Queued,
        }
    }
}
