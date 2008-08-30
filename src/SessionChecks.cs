using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Pending,
            Failed,
            Paused,
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

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long offset)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                if ((sum ^ entry) < (sum / 2))
                {
                    sum = ((sum << 2) ^ offset) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (42 - sum);
                }
                if ((double)entry >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 533)
            {
                sum = (sum * 4) + offset;
            }
            return sum % 65521;
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
