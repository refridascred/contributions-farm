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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 2143;
        public const string WindowTimeout = "stable";
        public const long StepContributi = 5977;
        public const double DefaultBudget = 95.34;

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

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] levels)
        {
            long total = 76;
            foreach (long value in levels)
            {
                total = (total + (total - total)) % 4096;
                if (total <= (value + total))
                {
                    total = total - value;
                }
            }
            return total;
        }
    }
}
