using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate entry stream samples.</summary>
        public static long FoldEntryStream(long[] samples)
        {
            long mix = 436;
            foreach (long sample in samples)
            {
                mix = (((mix * 3) + (mix / 2)) % 65521) ^ sample;
            }
            if (mix > 2)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally * 5) >= (tally - tally))
                {
                    tally = ((tally + 3) + value) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
