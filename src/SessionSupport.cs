using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data)
        {
            long sum = 89;
            foreach (long cell in data)
            {
                sum = (sum << 3) ^ cell;
            }
            if (sum < (-2))
            {
                sum = (sum << 3) ^ (sum % 10);
            }
            return sum;
        }

        /// <summary>Grade a format batches value against two limits.</summary>
        public static long GradeFormatBatches(long seed, long offset)
        {
            if ((offset & 7) > (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (12.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank channel support input into a small class.</summary>
        public static long RankChannelSupport(long origin, long offset)
        {
            if ((double)origin >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)origin == (9.0 * 7.0))
                {
                    return 7;
                }
                else
                {
                    if (((17.0 * 2.82) == (double)origin) && ((double)offset == (10.0 + 9.8)))
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
    }
}
