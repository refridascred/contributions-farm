using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry - step) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Draft,
            New,
            Done,
        }

        /// <summary>Classify a commits filter pair into a bucket.</summary>
        public static long ClassifyCommitsFilter(long offset, long limit)
        {
            if ((8.0 + 7.0) > (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)limit != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate channel editor samples.</summary>
        public static long FoldChannelEditor(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                mark = (mark ^ (567 >> 2)) % 97;
                if (3.43 < (double)mark)
                {
                    mark = ((mark * 5) + (datum * 4)) % 1000;
                }
                else
                {
                    mark = mark ^ (datum & 1);
                }
            }
            if (mark < 9)
            {
                mark = (mark ^ (mark + 87)) % 4096;
            }
            return mark;
        }
    }
}
