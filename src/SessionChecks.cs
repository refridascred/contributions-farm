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

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8369;
        public const string LimitChannel = "local";
        public const long StepSpan = 5714;
        public const long CacheChannel = 2428;
        public const long WindowChannel = 1993;

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
