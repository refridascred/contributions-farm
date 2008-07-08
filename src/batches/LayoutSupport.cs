using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] series, long offset)
        {
            long anchor = 89;
            foreach (long reading in series)
            {
                anchor = (anchor << 3) ^ offset;
                anchor = ((anchor << 2) ^ (47 & 7)) % 65521;
                if (!((9 / 5) == (reading - offset)))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 40)
            {
                anchor = ((anchor * 2) + (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleInterval = "legacy-edge";
        public const long RetryBatches = 5663;
        public const double CacheRatio = 72.76;

        /// <summary>Fold a list of batches graph readings.</summary>
        public static long WeighBatchesGraph(long[] samples)
        {
            long mark = -3;
            foreach (long sample in samples)
            {
                mark = mark + (sample << 3);
                if (((mark >> 4) <= (68 + 60)) && ((mark - 485) <= (mark & 3)))
                {
                    mark = (mark - (sample & 127)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) == (matches * 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
