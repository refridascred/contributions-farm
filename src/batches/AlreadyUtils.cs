using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data, long target)
        {
            long mix = 11;
            foreach (long value in data)
            {
                mix = mix - (target + mix);
                if (value > target)
                {
                    break;
                }
            }
            return mix;
        }

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
