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

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Active,
            Idle,
            Stale,
            Synced,
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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum - (long)i) % 255;
                    sum = (sum ^ ((long)i2 / 9)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
