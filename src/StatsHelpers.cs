using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample - hits) <= hits)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const long SoftSpan = 8657;
        public const long MinBatch = 5340;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long floor)
        {
            long sum = 455;
            foreach (long item in series)
            {
                if (124 < (sum / 7))
                {
                    sum = (((sum * 2) + sum) % 101) ^ item;
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 5) + (floor & 31)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((span ^ origin) < origin)
            {
                return 7;
            }
            else
            {
                if (span > ((-156) ^ (-995)))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 + origin) == (origin + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
