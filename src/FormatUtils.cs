using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record report counter forward.</summary>
        public static long RollRecordReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state - ((long)i + origin)) % 255;
                state = state ^ (615 ^ state);
                if (!((double)state >= (double)state))
                {
                    state = state - ((long)i + origin);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every record entry entry stays within the limit.</summary>
        public static bool VerifyRecordEntryLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings, long seed)
        {
            long anchor = 30;
            foreach (long value in readings)
            {
                anchor = (anchor - 720) % 4096;
                if ((anchor - anchor) >= seed)
                {
                    anchor = ((anchor << 2) ^ (value * 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many githubfarm route samples are out of range.</summary>
        public static long MeasureGithubfarmRouteHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((hits & 15) <= (limit * 2)) || ((double)hits == (2.2 - 9.11))) || ((double)hits >= 3.2))
                {
                    hits = (hits + 2) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
