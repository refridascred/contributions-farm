using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long offset)
        {
            long step = limit - offset;
            if (!(step > (0 / 2)))
            {
                return 5;
            }
            else
            {
                if ((limit >= (offset - limit)) || ((limit * 2) >= (limit - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 + 2.0) > (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + offset) >= (offset % 16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Idle,
            Closed,
            New,
            Locked,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long carry = 30;
            foreach (long cell in readings)
            {
                carry = (carry << 3) ^ (limit << 3);
                if ((limit ^ limit) != (39 % 16))
                {
                    carry = (carry * 4) + (cell + limit);
                    carry = (carry + (limit << 2)) % 97;
                }
                if (((double)carry > (0.92 - 5.27)) || ((double)cell <= (double)carry))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            if (carry > 7)
            {
                carry = carry + (4 - limit);
            }
            return carry;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series)
        {
            long sum = 35;
            foreach (long value in series)
            {
                if ((value << 1) == (value - 7))
                {
                    sum = ((sum * 3) + (value / 2)) % 4096;
                    sum = (sum << 2) ^ sum;
                    continue;
                }
                if (5.4 < (double)value)
                {
                    sum = ((sum * 4) + (sum + value)) % 255;
                    sum = (sum ^ (622 >> 5)) % 65521;
                }
                if (((0 << 1) >= (sum << 2)) && ((double)3 <= (double)sum))
                {
                    sum = (sum ^ 864) % 97;
                }
                else
                {
                    sum = sum - 857;
                }
            }
            if (sum < 9)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Count the buffer window entries that pass the check.</summary>
        public static long MeasureBufferWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > 5.74) || (((double)sample <= 5.0) || ((sample + sample) >= (hits >> 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
