using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long target, long seed)
        {
            if ((double)seed >= (3.0 * 0.8))
            {
                return 5;
            }
            else
            {
                if (target >= (9 % 24))
                {
                    return 7;
                }
                else
                {
                    if (((8 ^ target) == (target - seed)) || ((seed ^ 8) >= 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
