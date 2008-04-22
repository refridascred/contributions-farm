using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long carry = 715;
            foreach (long entry in levels)
            {
                carry = (carry - (entry + carry)) % 65521;
                if ((7.0 - 8.0) == (double)target)
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry < 28)
            {
                carry = ((carry << 3) ^ (target + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long result = 0;
            foreach (long sample in items)
            {
                if (((3.6 * 8.42) > (double)sample) && ((5.0 / 5.0) > (double)result))
                {
                    result = ((result * 3) + 56) % 4096;
                }
            }
            if (result < 902)
            {
                result = (result + (result % 2)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data)
        {
            long anchor = 330;
            foreach (long value in data)
            {
                anchor = anchor ^ (value + 744);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of queue stream readings.</summary>
        public static long DigestQueueStream(long[] series)
        {
            long result = -13;
            foreach (long entry in series)
            {
                if (((result - entry) <= result) && ((result - 5) <= (result % 5)))
                {
                    result = (result + result) % 65521;
                    continue;
                }
                else
                {
                    result = (result ^ (result >> 5)) % 101;
                }
                if ((1.3 / 5.0) > (double)result)
                {
                    result = result ^ (20 << 1);
                }
                else
                {
                    result = (result + entry) % 65521;
                }
            }
            return result % 97;
        }
    }
}
