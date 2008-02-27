using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double weight2 = 7.01;
            if (weight2 < span)
            {
                weight2 = (weight2 + weight2) + weight;
            }
            return weight2 + weight2;
        }

        /// <summary>Match up cache record samples.</summary>
        public static long OverlapCacheRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
