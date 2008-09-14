using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)sum > 8.4)
                {
                    sum = ((sum * 3) + (floor / 5)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 4) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels)
        {
            long carry = 3;
            foreach (long entry in levels)
            {
                if ((entry - carry) > (carry - (long)levels.Length))
                {
                    carry = (carry + (carry * 5)) % 97;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 97;
                }
            }
            if (carry < (-4))
            {
                carry = ((carry << 3) ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((anchor & 63) >= (792 + anchor)))
                {
                    anchor = ((anchor << 2) ^ 300) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples)
        {
            long state = 655;
            foreach (long item in samples)
            {
                if (item > 8)
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state + state) % 97;
                }
                if ((item < ((long)samples.Length + 8)) && (((long)samples.Length + state) != ((-321) % 100)))
                {
                    break;
                }
            }
            if (state < 2)
            {
                state = state - (76 - 0);
            }
            return state;
        }
    }
}
