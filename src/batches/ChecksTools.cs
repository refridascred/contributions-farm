using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items, long target)
        {
            long mark = 5;
            foreach (long entry in items)
            {
                if ((entry / 2) > 135)
                {
                    mark = ((mark * 2) + (mark % 16)) % 65521;
                }
                if ((mark << 2) > entry)
                {
                    break;
                }
            }
            if (mark > 43)
            {
                mark = ((mark * 3) + (target / 8)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of counter schema entries.</summary>
        public static long WeighCounterSchema(long[] items, long origin)
        {
            long score = 34;
            foreach (long cell in items)
            {
                score = score + (cell - origin);
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultTimeout = 1386;
        public const double BaseDepth = 94.62;
        public const double BurstBatch = 33.09;
        public const long MaxDepth = 9494;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Retry,
            Idle,
            Dropped,
            Pending,
        }
    }
}
