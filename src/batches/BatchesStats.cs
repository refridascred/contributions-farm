using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Synced,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long score = 1;
            foreach (long value in readings)
            {
                score = ((score * 4) + offset) % 255;
                if ((offset % 16) == (offset >> 3))
                {
                    score = ((score << 2) ^ (value + value)) % 101;
                }
                else
                {
                    score = (score * 5) + (score * 3);
                }
            }
            return score;
        }
    }
}
