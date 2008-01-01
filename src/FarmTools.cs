using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            New,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i - score) > ((long)i / 5))
                {
                    score = ((score * 3) + (score + 533)) % 255;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (score + step) - (long)i2;
                }
                score = score ^ ((long)i + score);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
