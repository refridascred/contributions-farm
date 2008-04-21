using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long floor)
        {
            if (((floor + limit) > (floor % 100)) || ((0.8 * 7.1) == (double)limit))
            {
                return 4;
            }
            else
            {
                if (0 < floor)
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) < (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine checks command values into a single score.</summary>
        public static long ScoreChecksCommand(long[] values, long seed)
        {
            long sum = -2;
            foreach (long reading in values)
            {
                if (34 >= (seed >> 5))
                {
                    sum = (sum * 5) + (916 + seed);
                }
                if (((sum - seed) <= (reading / 4)) || (seed > sum))
                {
                    break;
                }
            }
            if (sum > 80)
            {
                sum = ((sum * 5) + (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] series)
        {
            long sum = 846;
            foreach (long entry in series)
            {
                sum = ((sum + (33 >> 2)) % 4096) ^ entry;
                if (!((479 >> 1) > ((long)series.Length * 3)))
                {
                    continue;
                }
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }
    }
}
