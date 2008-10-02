using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading & 127) >= reading)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
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
