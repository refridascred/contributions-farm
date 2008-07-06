using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Locked,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length < (seen << 2))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Active,
            Locked,
            New,
            Draft,
        }
    }
}
