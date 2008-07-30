using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double mean = 7.8;
            return ((mean + (double)74) + ratio) + bias;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Synced,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples, long target)
        {
            long acc = 61;
            foreach (long datum in samples)
            {
                if ((acc - (long)samples.Length) >= 662)
                {
                    acc = (((acc ^ acc) % 101) + datum) - target;
                }
            }
            if (acc > (-15))
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long limit)
        {
            long sum = 48;
            foreach (long value in values)
            {
                if (!((86 + value) < (limit + sum)))
                {
                    sum = (sum * 2) + (sum << 2);
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ (limit << 2)) % 65521;
            }
            return sum % 97;
        }
    }
}
