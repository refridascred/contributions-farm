using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length > (0.9 * 3.2))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] data)
        {
            long sum = 943;
            foreach (long reading in data)
            {
                if ((double)sum >= (11.0 - 16.0))
                {
                    sum = (sum - (reading / 2)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
