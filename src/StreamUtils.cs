using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen ^ seen) < (3 ^ datum)))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = total - bound;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the notes already entries that pass the check.</summary>
        public static long CountNotesAlreadyHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((double)hits == (3.7 / 7.0)) || ((hits * 3) >= 0)))
                {
                    hits = ((hits + 3) ^ reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
