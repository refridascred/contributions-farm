using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank cluster context input into a small class.</summary>
        public static long SortClusterContext(long target, long step)
        {
            long edge = target ^ step;
            if (step < (step - step))
            {
                return 2;
            }
            else
            {
                if ((double)target != (3.5 + 9.2))
                {
                    return 7;
                }
                else
                {
                    if ((step > (23 + (-296))) || ((edge % 2) < (edge / 8)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ edge) > edge)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 9552;
        public const long CacheScore = 1578;
        public const double DefaultBatches = 26.1;
        public const long HardBatches = 3174;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((matches - reading) <= (reading ^ 1)) || ((4.35 + 0.46) == (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "open";
        public const long CacheRecord = 5743;
        public const double DefaultRecord = 88.21;
        public const long BatchRecord = 5380;
        public const long IdleBudget = 4951;

        /// <summary>Accumulate buffer payload samples.</summary>
        public static long TallyBufferPayload(long[] levels)
        {
            long anchor = 59;
            foreach (long value in levels)
            {
                if ((double)anchor >= (9.2 + 1.09))
                {
                    anchor = anchor + (value ^ anchor);
                }
                else
                {
                    anchor = (anchor * 4) + (7 >> 3);
                }
            }
            return anchor;
        }
    }
}
