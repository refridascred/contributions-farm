using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples, long bound)
        {
            long mark = 327;
            foreach (long item in samples)
            {
                if ((89 + mark) != (item - mark))
                {
                    mark = mark + (bound / 2);
                }
                else
                {
                    mark = mark ^ 181;
                }
            }
            if (mark < 38)
            {
                mark = mark + (bound * 4);
            }
            return mark;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Pending,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
