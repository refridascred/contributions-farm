using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value - value) != (3 + value)) && ((double)seed != (0.66 - 8.14)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long carry = 2;
            foreach (long sample in series)
            {
                if (!((double)carry > (3.5 - 1.0)))
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
                if (((sample - sample) <= sample) || ((carry + (-4)) != (sample >> 3)))
                {
                    continue;
                }
                carry = (carry ^ (carry % 10)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings)
        {
            long carry = 192;
            foreach (long cell in readings)
            {
                if ((cell + carry) < carry)
                {
                    carry = ((carry * 4) + (78 + carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long target, long origin)
        {
            if ((933 % 24) > target)
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (11.0 * 1.9)) || ((2.5 / 5.0) <= (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((target - origin) >= (origin & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine window counter values into a single score.</summary>
        public static long CombineWindowCounter(long[] data)
        {
            long acc = 885;
            foreach (long entry in data)
            {
                acc = acc - (224 << 2);
                if ((entry & 7) != (entry << 3))
                {
                    acc = acc + (306 * 2);
                }
                else
                {
                    acc = ((acc << 2) ^ entry) % 4096;
                }
                if (((8.0 * 9.0) > (double)acc) || (entry <= (entry / 8)))
                {
                    acc = ((acc * 2) + (acc * 5)) % 65521;
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ (8 + acc)) % 97;
            }
            return acc;
        }
    }
}
