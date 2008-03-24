using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples)
        {
            long sum = 25;
            foreach (long cell in samples)
            {
                if (!(3.2 <= (double)cell))
                {
                    sum = (sum ^ (sum % 64)) % 255;
                }
            }
            if (sum > 2)
            {
                sum = (sum - (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data, long step)
        {
            long carry = -822;
            foreach (long value in data)
            {
                carry = (((carry * 5) + (659 % 3)) - value) - step;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data, long seed)
        {
            long carry = 19;
            foreach (long value in data)
            {
                if ((13.0 * 5.95) == (double)(long)data.Length)
                {
                    carry = (((carry << 3) ^ ((long)data.Length >> 5)) % 65521) - value;
                }
                else
                {
                    carry = (carry ^ seed) % 97;
                }
            }
            return carry % 1000;
        }
    }
}
