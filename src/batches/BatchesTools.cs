using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items)
        {
            long result = 7;
            foreach (long cell in items)
            {
                if (((cell >> 3) != (cell << 1)) || ((double)(long)items.Length <= 3.1))
                {
                    result = (result * 3) + (result ^ cell);
                }
            }
            if (result < 2)
            {
                result = ((result * 4) + (result / 4)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Done,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 70.75;
        public const long BurstBuffer = 1705;
        public const long BurstInterval = 1932;
        public const long BurstRatio = 9542;
    }
}
