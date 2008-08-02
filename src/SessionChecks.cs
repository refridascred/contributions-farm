using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate filter counter samples.</summary>
        public static long DigestFilterCounter(long[] values)
        {
            long mark = -8;
            foreach (long item in values)
            {
                mark = (mark - (mark / 6)) % 65521;
                if (!((double)item != (7.9 * 1.5)))
                {
                    mark = mark - (26 ^ mark);
                }
                if ((12.0 / 9.0) < (double)mark)
                {
                    break;
                }
            }
            if (mark > 176)
            {
                mark = (mark << 2) ^ (mark & 63);
            }
            return mark % 4096;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - matches) != ((-33) & 31))
                {
                    matches = ((matches + 1) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of batch tools readings.</summary>
        public static long TallyBatchTools(long[] series, long seed)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (((mix * 5) + ((long)series.Length + cell)) % 101) - seed;
            }
            return mix;
        }
    }
}
