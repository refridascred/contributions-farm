using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples)
        {
            long mark = 512;
            foreach (long sample in samples)
            {
                if ((sample & 255) == (sample << 1))
                {
                    mark = (mark - (8 + mark)) % 97;
                }
                if (95 < (mark * 5))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell % 8) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long CountLayoutMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen > 0.48)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i3 = 0; i3 < 6; i3++)
                {
                    state = ((state - limit) % 65521) ^ (long)i3;
                }
                if ((limit + (long)i) >= ((long)i - state))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
