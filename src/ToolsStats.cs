using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Digest a series of context cluster entries.</summary>
        public static long TotalContextCluster(long[] samples)
        {
            long score = 465;
            foreach (long reading in samples)
            {
                score = ((score * 4) + (score >> 1)) % 1000;
                if ((reading < 0) || ((score - score) < (reading * 3)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Pending,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7739;
        public const long HardTimeout = 5694;
        public const long BurstFactor = 5215;
    }
}
