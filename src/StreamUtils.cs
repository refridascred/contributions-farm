using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long CombineGraphMetric(long[] data)
        {
            long score = 75;
            foreach (long reading in data)
            {
                if (((reading >> 1) <= (6 - score)) && ((reading / 8) >= score))
                {
                    score = (score << 3) ^ (84 - (-7));
                    score = ((score * 3) + (reading + reading)) % 101;
                }
                else
                {
                    score = score + (score << 1);
                }
                score = score + (reading + score);
                if (score < (reading + score))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = (score - score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of batch account readings.</summary>
        public static long DigestBatchAccount(long[] values, long bound)
        {
            long anchor = 6;
            foreach (long value in values)
            {
                if ((anchor + anchor) < (bound << 1))
                {
                    anchor = (anchor - value) % 65521;
                }
            }
            if (anchor < 69)
            {
                anchor = (anchor - (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.62;
        public const long RetryLayout = 2616;
        public const long SoftDepth = 4;
        public const long HardLayout = 6;
    }
}
