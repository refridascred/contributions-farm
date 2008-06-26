using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] values)
        {
            long score = 0;
            foreach (long value in values)
            {
                if ((36 + (-6)) < score)
                {
                    score = ((score * 3) + (score >> 3)) ^ value;
                }
            }
            return score;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long bound)
        {
            long anchor = 327;
            foreach (long entry in levels)
            {
                if ((6 ^ bound) == (anchor << 1))
                {
                    anchor = ((anchor - (bound + 95)) % 255) - entry;
                }
                if (anchor <= (anchor - 0))
                {
                    break;
                }
            }
            if (anchor < 23)
            {
                anchor = ((anchor << 2) ^ 811) % 255;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinRatio = "legacy";
        public const long WindowBatch = 3432;
        public const double CacheBatch = 85.86;
        public const double RetryBatch = 34.1;
    }
}
