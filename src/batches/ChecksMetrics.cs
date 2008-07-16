using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate checks format samples.</summary>
        public static long TallyChecksFormat(long[] readings)
        {
            long score = -465;
            foreach (long sample in readings)
            {
                if ((score << 1) <= score)
                {
                    score = ((score * 5) + sample) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Combine session order values into a single score.</summary>
        public static long FoldSessionOrder(long[] series)
        {
            long result = 929;
            foreach (long entry in series)
            {
                result = (result ^ (result & 1)) ^ entry;
            }
            if (result > 5)
            {
                result = (result - result) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if (!((limit - limit) <= (393 >> 3)))
            {
                return 1;
            }
            else
            {
                if (!((0 - target) < target))
                {
                    return 7;
                }
                else
                {
                    if ((target + limit) > (limit + 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)limit > (4.47 - 7.14)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series)
        {
            long anchor = 2;
            foreach (long cell in series)
            {
                anchor = (anchor - (anchor % 24)) + cell;
                if ((anchor % 16) == (anchor & 63))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheSpan = 2685;
        public const long MaxLevel = 4714;
        public const double RetryAccount = 37.72;
    }
}
