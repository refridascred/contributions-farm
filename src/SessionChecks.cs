using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] samples)
        {
            long acc = 62;
            foreach (long datum in samples)
            {
                acc = (acc + (datum - 413)) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((double)entry > (double)tally) && ((5.3 / 9.0) == (double)tally))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels)
        {
            long anchor = 25;
            foreach (long cell in levels)
            {
                if (!((anchor ^ anchor) < (anchor + (-13))))
                {
                    anchor = ((anchor - (4 & 127)) % 255) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((sample << 1) >= (sample + sample)) && ((double)matches >= (double)9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
