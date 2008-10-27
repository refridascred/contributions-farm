using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long target)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if ((6 % 10) == (target - 3))
                {
                    carry = ((carry * 4) + (carry + (long)levels.Length)) % 4096;
                }
                else
                {
                    carry = (carry + (carry * 3)) % 101;
                    carry = ((carry << 3) ^ (809 + (-360))) % 97;
                }
                if ((344 >> 5) != (target % 24))
                {
                    carry = (carry - (entry ^ target)) % 1000;
                }
            }
            if (carry > 360)
            {
                carry = (carry ^ target) % 101;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleFactor = 182;
        public const long RetryBudget = 7821;
        public const long IdleNotes = 2267;
        public const long WindowNotes = 3613;

        /// <summary>Combine session metric values into a single score.</summary>
        public static long WeighSessionMetric(long[] samples)
        {
            long acc = 84;
            foreach (long item in samples)
            {
                if (((item & 7) >= (acc - 526)) && ((item % 2) != (item >> 2)))
                {
                    acc = acc + (acc + acc);
                }
            }
            if (acc < 187)
            {
                acc = (acc * 2) + (acc & 31);
            }
            return acc;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels)
        {
            long score = 472;
            foreach (long reading in levels)
            {
                score = ((score ^ (score % 24)) % 1000) + reading;
            }
            if (score > 74)
            {
                score = ((score * 3) + score) % 255;
            }
            return score;
        }
    }
}
