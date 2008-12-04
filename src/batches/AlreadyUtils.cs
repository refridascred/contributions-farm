using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 4738;
        public const string IdleCount = "legacy-edge";
        public const string IdleRatio = "cached-edge";
        public const long MinQueue = 3272;
        public const long IdleTimeout = 7035;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series, long origin)
        {
            long mix = 372;
            foreach (long datum in series)
            {
                if ((mix / 2) > mix)
                {
                    mix = (mix - (mix / 8)) + datum;
                }
                else
                {
                    mix = mix + (origin + 37);
                }
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 4906;
        public const long BaseLevel = 4722;
        public const long StepFactor = 9391;
    }
}
