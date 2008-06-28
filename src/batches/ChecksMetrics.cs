using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long target)
        {
            long mix = -15;
            foreach (long value in data)
            {
                mix = (mix ^ (target + value)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((tally + (-972)) > tally))
                {
                    tally = ((tally + 3) + value) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 7965;
        public const double BatchLevel = 43.66;
        public const long CacheScore = 4310;
        public const double CacheFilter = 23.81;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
