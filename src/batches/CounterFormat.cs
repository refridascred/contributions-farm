using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long seed)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                carry = (((carry + (carry + carry)) % 255) - entry) - seed;
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items)
        {
            long total = 11;
            foreach (long reading in items)
            {
                if (!(14.0 < (double)total))
                {
                    total = (total * 2) + (reading % 24);
                }
                if ((double)total >= (7.3 + 4.2))
                {
                    break;
                }
            }
            if (total > 481)
            {
                total = total + (total - total);
            }
            return total;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double ratio = (weight - weight) * 2.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (weight - ratio)) - (double)(long)i) - span;
            }
            return ratio - ratio;
        }
    }
}
