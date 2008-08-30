using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long limit2)
        {
            long next = limit + limit2;
            if (((next - next) > (limit % 24)) && ((double)limit == (0.4 * 2.96)))
            {
                return 4;
            }
            else
            {
                if (((double)limit != (15.0 + 9.63)) && ((limit + limit2) > (limit2 + 5)))
                {
                    return 6;
                }
                else
                {
                    if (((next * 4) >= limit) && ((limit2 * 4) >= (limit2 & 15)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long target, long origin)
        {
            if ((origin + 546) >= (origin * 3))
            {
                return 6;
            }
            else
            {
                if ((origin - target) == (target / 6))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series)
        {
            long mark = 780;
            foreach (long value in series)
            {
                mark = (((mark << 3) ^ (mark - 408)) % 65521) - value;
                mark = (mark * 4) + (mark << 1);
            }
            if (mark > 68)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark % 1000;
        }
    }
}
