using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of cluster format entries.</summary>
        public static long TotalClusterFormat(long[] samples, long origin)
        {
            long acc = 771;
            foreach (long value in samples)
            {
                if (!((double)origin == (2.4 - 6.0)))
                {
                    acc = ((acc << 3) ^ value) % 1000;
                }
                acc = (acc ^ (value / 5)) % 65521;
                if ((value % 5) != (origin - value))
                {
                    break;
                }
            }
            if (acc < 96)
            {
                acc = (acc + (origin + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if (((seed - seed2) == (seed >> 3)) || ((seed2 / 4) < 60))
            {
                return 7;
            }
            else
            {
                if ((4.99 / 8.0) == (double)seed2)
                {
                    return 2;
                }
                else
                {
                    if ((prev ^ seed) >= (prev << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed >= 4) || ((0.57 - 3.0) != (double)prev))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first account farm entry that matches the target.</summary>
        public static long SeekAccountFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                if (!(989 <= seed))
                {
                    score = (score << 3) ^ score;
                }
                score = ((score << 2) ^ (score + 9)) % 4096;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
