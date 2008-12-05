using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading / 5) == (29 + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + (sum >> 2);
                if (limit >= ((long)i + 8))
                {
                    sum = ((sum << 2) ^ (long)i) % 65521;
                    sum = (sum << 3) ^ (long)i;
                }
                sum = (sum * 4) + (3 - limit);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels, long step)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                carry = ((carry + (9 * 5)) + entry) + step;
            }
            return carry;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Pending,
            Dropped,
            Done,
            Active,
        }
    }
}
