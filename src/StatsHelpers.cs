using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings, long offset)
        {
            long anchor = 537;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ (anchor + cell)) - offset;
            }
            return anchor;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next entry contributi value from a seed.</summary>
        public static long SeriesEntryContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step / 8) == (5 * 5))
                {
                    mix = (mix * 5) + (mix + step);
                }
                else
                {
                    mix = mix ^ mix;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
