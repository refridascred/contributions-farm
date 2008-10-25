using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
