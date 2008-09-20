using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long step, long limit)
        {
            long next = step + limit;
            if (limit >= step)
            {
                return 0;
            }
            else
            {
                if ((step % 100) == (limit + step))
                {
                    return 5;
                }
                else
                {
                    if ((0 / 3) == (step / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((0.75 + 4.61) == (double)next) && ((step % 2) > (next % 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Queued,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
