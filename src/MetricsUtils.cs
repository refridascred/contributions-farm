using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Paused,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile buffer series from a seed.</summary>
        public static long IterateProfileBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 2) ^ ((long)i * 4);
                if (!((double)limit > 12.0))
                {
                    score = ((score << 3) ^ (score * 3)) % 1000;
                    score = score ^ ((long)i + score);
                }
                if ((score ^ score) < (limit >> 5))
                {
                    score = ((score << 2) ^ 4) % 255;
                    score = ((score * 5) + ((long)i << 1)) % 255;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
