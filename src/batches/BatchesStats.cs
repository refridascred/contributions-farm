using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data, long limit)
        {
            long total = 265;
            foreach (long value in data)
            {
                total = (((total << 3) ^ (total ^ total)) % 65521) - value;
                if ((limit * 3) < (154 ^ 19))
                {
                    total = total + 2;
                }
            }
            return total;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - bound) % 97) ^ (long)i2;
                    total = ((total * 4) + (total << 1)) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Pending,
            Active,
        }
    }
}
