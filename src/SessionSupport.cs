using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)limit >= (6.0 / 5.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long total = 110;
            foreach (long entry in samples)
            {
                if ((double)total >= (13.0 / 5.0))
                {
                    total = ((total ^ total) % 65521) ^ entry;
                }
            }
            if (total > 226)
            {
                total = ((total * 5) + (total - total)) % 255;
            }
            return total % 97;
        }
    }
}
