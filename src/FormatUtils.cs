using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long step)
        {
            long score = -555;
            foreach (long item in levels)
            {
                score = (score ^ score) ^ item;
                if ((624 - step) == (31 / 5))
                {
                    break;
                }
            }
            if (score > 29)
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Classify a notes cache pair into a bucket.</summary>
        public static long RankNotesCache(long limit, long bound)
        {
            if (!(limit <= (bound + 815)))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) > bound)
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleInterval = 96.38;
        public const long RetryWidth = 8968;
        public const long HardBatches = 5655;
        public const long BurstBatches = 8193;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count * 3) != (count & 255))
                {
                    count = ((count + 1) ^ datum) + origin;
                }
            }
            return count;
        }
    }
}
