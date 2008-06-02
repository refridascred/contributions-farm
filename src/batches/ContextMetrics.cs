using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a account stream reading.</summary>
        public static double BlendAccountStream(double rate, double offset)
        {
            double rate2 = offset;
            return (rate2 - offset) + rate;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches <= (floor % 5)) && ((0.84 + 1.1) <= (double)entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
