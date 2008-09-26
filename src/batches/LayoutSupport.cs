using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] items, long step)
        {
            long sum = 11;
            foreach (long sample in items)
            {
                if (step < sample)
                {
                    sum = sum ^ (21 - step);
                }
                else
                {
                    sum = (sum ^ (step >> 1)) % 1000;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double weight = (double)(5 << 1);
            return (weight + (floor / 7.0)) + bias;
        }

        /// <summary>Digest a series of buffer record entries.</summary>
        public static long DigestBufferRecord(long[] data, long step)
        {
            long state = -9;
            foreach (long value in data)
            {
                state = state - 847;
                if (!((state ^ value) > (step ^ value)))
                {
                    state = state - (state << 1);
                }
                else
                {
                    state = (state ^ (value & 127)) % 97;
                }
            }
            if (state < 108)
            {
                state = state ^ (312 - state);
            }
            return state;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum <= (datum / 8))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
