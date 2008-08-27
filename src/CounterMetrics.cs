using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the farm stream series from a seed.</summary>
        public static long DeriveFarmStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((mark <= (limit >> 4)) || ((limit / 6) == (mark - (-470))))
                {
                    mark = (mark + 457) % 255;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items)
        {
            long carry = 622;
            foreach (long item in items)
            {
                carry = ((carry * 3) + carry) % 97;
                carry = carry ^ item;
                if (((double)carry > (double)item) && ((double)item != (double)carry))
                {
                    carry = ((carry << 3) ^ (carry & 7)) % 101;
                }
                if (item <= carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long IterateMetricLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data, long step)
        {
            long state = 199;
            foreach (long sample in data)
            {
                if (step > (sample * 5))
                {
                    state = (state - (step + sample)) % 65521;
                }
            }
            return state % 65521;
        }
    }
}
