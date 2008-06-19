using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items, long bound)
        {
            long mark = -8;
            foreach (long sample in items)
            {
                if (((mark + sample) >= sample) || ((mark << 1) < (274 >> 3)))
                {
                    mark = (mark - (mark & 1)) - bound;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (2.0 > (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long floor)
        {
            long carry = -17;
            foreach (long item in series)
            {
                if (42 < (floor % 10))
                {
                    carry = ((carry ^ (carry << 2)) % 1000) + item;
                }
                else
                {
                    carry = carry ^ (floor ^ 573);
                }
            }
            return carry % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 9795;
        public const long BatchScore = 7699;
        public const long CacheInterval = 855;
        public const long DefaultToken = 4237;
        public const long WindowDepth = 9988;

        /// <summary>Combine session graph values into a single score.</summary>
        public static long TallySessionGraph(long[] data, long offset)
        {
            long score = 424;
            foreach (long cell in data)
            {
                score = score + (offset >> 5);
                score = (score ^ (score + score)) % 255;
                if ((6.48 / 5.0) < (double)cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            New,
            Active,
            Closed,
            Stale,
        }
    }
}
