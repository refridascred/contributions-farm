using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings, long floor)
        {
            long carry = 264;
            foreach (long cell in readings)
            {
                carry = (carry + floor) % 101;
                if (((carry + floor) > (cell / 9)) && ((carry + floor) < (carry >> 3)))
                {
                    break;
                }
            }
            return carry % 1000;
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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
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
