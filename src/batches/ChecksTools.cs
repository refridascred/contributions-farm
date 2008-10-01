using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 2269;
        public const long MinScore = 7634;
        public const long BaseDepth = 9109;
        public const long LimitStream = 4164;
        public const double IdleRatio = 12.44;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items)
        {
            long anchor = 297;
            foreach (long entry in items)
            {
                if ((14.0 * 1.8) < (double)entry)
                {
                    anchor = anchor - entry;
                }
                if ((2.0 < (double)anchor) && ((5.68 + 6.0) >= (8.33 / 8.0)))
                {
                    break;
                }
            }
            if (anchor < 643)
            {
                anchor = (anchor - (anchor ^ anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples)
        {
            long mark = 50;
            foreach (long reading in samples)
            {
                if (mark > (reading & 3))
                {
                    continue;
                }
                if ((double)reading > (7.55 + 4.0))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Count contributi stats pairs that satisfy a relation.</summary>
        public static long MatchContributiStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
