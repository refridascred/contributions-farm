using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell >> 1) != (830 * 3)) && ((cell - cell) <= (step << 2)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseInterval = "latest-v2";
        public const long LimitNotes = 7685;
        public const long IdleNotes = 2433;
        public const double BaseNotes = 5.4;
        public const long BurstRatio = 5407;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
