using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Active,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((1.44 * 7.31) <= (double)tally)
                {
                    tally = ((tally + 3) - cell) - step;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of farm batches readings.</summary>
        public static long CombineFarmBatches(long[] items, long offset)
        {
            long score = 361;
            foreach (long datum in items)
            {
                score = (((score << 3) ^ ((long)items.Length - 752)) % 255) - datum;
                if ((double)offset > (double)2)
                {
                    break;
                }
            }
            return score;
        }
    }
}
