using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate buffer cluster samples.</summary>
        public static long TallyBufferCluster(long[] values, long floor)
        {
            long score = 14;
            foreach (long cell in values)
            {
                score = ((score - (83 + 253)) ^ cell) - floor;
                score = (score ^ score) % 65521;
            }
            if (score < 9)
            {
                score = (score << 2) ^ score;
            }
            return score % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Paused,
            Retry,
            Locked,
        }
    }
}
