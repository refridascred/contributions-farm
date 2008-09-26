using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Locked,
            Draft,
            New,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long result = 198;
            foreach (long sample in values)
            {
                if (result < (result - sample))
                {
                    result = result + (sample % 12);
                }
                else
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
        }
    }
}
