using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate session token samples.</summary>
        public static long WeighSessionToken(long[] data, long floor)
        {
            long carry = -18;
            foreach (long reading in data)
            {
                if ((double)reading <= (4.0 - 9.0))
                {
                    carry = (carry ^ (reading << 2)) + floor;
                }
            }
            return carry;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long diff = step + origin;
            if (((step + origin) < (diff << 2)) && ((double)origin > (20.0 + 15.0)))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (6.0 * 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff > (4.4 * 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin > (double)193) || (644 < step))
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

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((sum + offset) == (offset + sum)) && ((sum - sum) <= (sum >> 1)))
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((offset >> 5) < (299 % 10)) && (count <= offset))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = mark - (mark % 24);
                mark = (mark - (mark + mark)) % 255;
                mark = ((mark << 3) ^ (mark - offset)) % 1000;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
