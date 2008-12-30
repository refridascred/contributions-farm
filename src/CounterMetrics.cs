using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = carry + carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinTimeout = 9928;
        public const string LimitMetrics = "alpha-v2";
        public const long BatchRatio = 3965;

        /// <summary>Measure how many already session samples are out of range.</summary>
        public static long TallyAlreadySessionMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6 % 97) < reading)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
