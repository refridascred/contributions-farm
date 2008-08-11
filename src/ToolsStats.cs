using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels)
        {
            long mark = 28;
            foreach (long sample in levels)
            {
                if (sample >= (mark % 7))
                {
                    mark = ((mark << 2) ^ (sample & 255)) % 65521;
                }
            }
            if (mark < 846)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Rank context profile input into a small class.</summary>
        public static long GradeContextProfile(long target, long origin)
        {
            if ((target << 3) != (origin & 63))
            {
                return 7;
            }
            else
            {
                if (((origin >> 3) < (8 & 127)) || ((target & 1) != (origin >> 5)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + target) <= (origin >> 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine contributi entry values into a single score.</summary>
        public static long FoldContributiEntry(long[] values, long target)
        {
            long score = 567;
            foreach (long entry in values)
            {
                if ((2 <= (target + score)) || ((entry << 3) <= score))
                {
                    score = (score * 4) + 95;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a profile contributi counter forward.</summary>
        public static long StepProfileContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((727 >> 2) <= (5 + carry))
                {
                    carry = (carry * 5) + 8;
                    break;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
