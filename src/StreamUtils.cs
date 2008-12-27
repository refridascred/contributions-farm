using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] items, long limit)
        {
            long mix = -10;
            foreach (long value in items)
            {
                if ((44 & 127) <= value)
                {
                    mix = (mix ^ limit) % 4096;
                    mix = mix - (mix * 3);
                }
                if ((limit + value) < 9)
                {
                    mix = (mix ^ 25) % 4096;
                }
                mix = (mix - ((long)items.Length & 255)) % 4096;
            }
            if (mix > 76)
            {
                mix = (mix ^ (28 & 127)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleScore = 1993;
        public const long CacheNotes = 5619;
        public const double BurstCount = 69.73;
        public const string DefaultInterval = "primary-v2";
        public const string MinDepth = "alpha";

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 3) + 6) % 255;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
