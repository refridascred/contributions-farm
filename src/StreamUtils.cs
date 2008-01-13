using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 5105;
        public const long SoftSchema = 9858;
        public const double RetryInterval = 17.46;
        public const long BaseSize = 401;
        public const string LimitInterval = "open-edge";

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long seed)
        {
            if ((offset << 2) < (offset ^ seed))
            {
                return 5;
            }
            else
            {
                if (((915 - 445) == (offset + seed)) || ((offset & 1) < (offset - seed)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long offset)
        {
            long mark = -799;
            foreach (long cell in series)
            {
                if ((cell - cell) == (cell - offset))
                {
                    mark = ((mark << 3) ^ (98 + cell)) % 1000;
                }
            }
            if (mark > 20)
            {
                mark = (mark << 3) ^ 97;
            }
            return mark;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long target)
        {
            long mark = 422;
            foreach (long item in values)
            {
                if ((164 << 3) < (item % 5))
                {
                    mark = (((mark << 3) ^ (mark + mark)) % 4096) - target;
                }
                else
                {
                    mark = (mark << 3) ^ (long)values.Length;
                }
            }
            if (mark < (-109))
            {
                mark = mark ^ (mark << 2);
            }
            return mark % 1000;
        }
    }
}
