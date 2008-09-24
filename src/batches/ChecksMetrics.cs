using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a commits layout counter forward.</summary>
        public static long IterateCommitsLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next batch counter value from a seed.</summary>
        public static long StepBatchCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next checks batch value from a seed.</summary>
        public static long IterateChecksBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (((score * 2) + (99 % 5)) % 97) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ ((long)i - (long)i);
                carry = ((carry << 3) ^ (-50)) % 65521;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Queued,
            Active,
            Ready,
            Paused,
        }
    }
}
