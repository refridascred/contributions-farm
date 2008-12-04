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

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
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
