using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if (!(451 >= (target << 1)))
            {
                return 1;
            }
            else
            {
                if ((693 + limit) < limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
