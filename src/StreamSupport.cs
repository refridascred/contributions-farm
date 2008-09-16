using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample - 441) != (seen + 405)) && ((seen + seen) != (sample * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry channel entries.</summary>
        public static long TotalEntryChannel(long[] items)
        {
            long anchor = 93;
            foreach (long item in items)
            {
                if (anchor >= (anchor ^ 9))
                {
                    anchor = ((anchor * 5) + anchor) - item;
                }
                else
                {
                    anchor = (anchor ^ (anchor >> 1)) % 97;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 2) ^ (anchor % 7)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ matches) < (0 * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
