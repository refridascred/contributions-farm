using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Ready,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 895;
        public const long BatchFarm = 1067;
        public const long DefaultFarm = 6055;
        public const long IdleFarm = 8005;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (sum + target)) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Queued,
            Done,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long origin)
        {
            if ((double)origin <= (7.7 - 5.9))
            {
                return 6;
            }
            else
            {
                if ((9.53 - 1.66) != (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) <= (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)3 == (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
