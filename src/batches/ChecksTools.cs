using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
