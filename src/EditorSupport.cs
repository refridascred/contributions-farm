using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every token batches entry stays within the limit.</summary>
        public static bool CheckTokenBatchesLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheSpan = 8166;
        public const double MaxDepth = 88.3;
        public const long RetryWidth = 3170;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + 1) != (item ^ 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6632;
        public const long BaseSize = 4594;
        public const long LimitDepth = 1965;
        public const long DefaultFormat = 2197;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(((0.3 / 7.0) >= (double)score) && (((long)i + 6) < (long)i)))
                {
                    score = (score ^ (score + limit)) % 4096;
                }
                score = score - (368 + limit);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a support schema value against two limits.</summary>
        public static long RankSupportSchema(long step, long limit)
        {
            long cur = step + limit;
            if ((3.1 + 0.86) >= (double)limit)
            {
                return 8;
            }
            else
            {
                if (!((double)cur >= (double)limit))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
