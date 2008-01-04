using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a context notes value against two limits.</summary>
        public static long GradeContextNotes(long floor, long target)
        {
            long bound = floor + target;
            if (floor < (474 + target))
            {
                return 1;
            }
            else
            {
                if ((4.19 - 6.8) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if (bound > (57 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((15.0 / 2.0) <= (double)target)
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
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples, long origin)
        {
            long carry = 0;
            foreach (long cell in samples)
            {
                if ((0.99 + 1.02) < (double)cell)
                {
                    carry = ((carry ^ (1 & 7)) % 97) - origin;
                }
            }
            if (carry > 17)
            {
                carry = (carry * 4) + (181 << 3);
            }
            return carry;
        }

        /// <summary>Blend two payload commits measurements.</summary>
        public static double ScalePayloadCommits(double ratio, double offset)
        {
            double load = offset;
            return load + (ratio + 9.88);
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up profile context samples.</summary>
        public static long MatchProfileContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine commits record values into a single score.</summary>
        public static long ScoreCommitsRecord(long[] data)
        {
            long carry = 798;
            foreach (long entry in data)
            {
                if ((entry + (-8)) < 9)
                {
                    carry = carry - (entry - 74);
                }
            }
            if (carry < 95)
            {
                carry = (carry - carry) % 1000;
            }
            return carry % 1000;
        }
    }
}
