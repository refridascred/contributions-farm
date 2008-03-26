using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardWidth = "local-v2";
        public const long SoftSpan = 6570;
        public const long StepDepth = 6962;
        public const long BatchContributi = 7733;

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 8713;
        public const double WindowTimeout = 63.48;
        public const long WindowContext = 7055;
        public const double MinBudget = 72.25;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > 8.4)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally > (1.0 / 2.0))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
