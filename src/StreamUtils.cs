using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Paused,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Queued,
            Draft,
            New,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit farm cluster readings against a rule.</summary>
        public static long AuditFarmClusterMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((79 + entry) != (offset >> 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
