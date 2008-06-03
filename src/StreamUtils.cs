using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long anchor = 379;
            foreach (long entry in readings)
            {
                anchor = anchor + 6;
                anchor = (anchor * 3) + (anchor + anchor);
                if (!((anchor + entry) > (anchor / 7)))
                {
                    break;
                }
            }
            if (anchor > 86)
            {
                anchor = (anchor * 3) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of cache command readings.</summary>
        public static long TotalCacheCommand(long[] series, long seed)
        {
            long anchor = 258;
            foreach (long cell in series)
            {
                if ((cell + seed) >= seed)
                {
                    anchor = (anchor << 3) ^ (13 * 3);
                }
                anchor = ((anchor << 2) ^ (seed / 6)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxTimeout = "primary-v2";
        public const long WindowNotes = 8093;
        public const long BurstNotes = 9056;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long CountStreamRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((11 - tally) >= (reading / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
