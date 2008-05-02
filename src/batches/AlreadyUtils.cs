using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheScore = "cached-edge";
        public const long RetryCommand = 5711;
        public const long DefaultCommand = 3612;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = (total << 3) ^ (total * 3);
                if ((double)offset < (9.42 / 3.0))
                {
                    total = (total + ((long)i % 8)) % 255;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxRatio = 35.78;
        public const double RetryBuffer = 4.04;
        public const long BurstRatio = 2714;
        public const string BaseBuffer = "open-edge";
        public const long StepScore = 3344;
    }
}
