using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metric buffer samples are out of range.</summary>
        public static long TallyMetricBufferGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ datum) == (count - datum))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] data, long offset)
        {
            long result = 570;
            foreach (long datum in data)
            {
                if ((offset % 5) > (datum - 639))
                {
                    result = result ^ (result & 15);
                }
            }
            if (result < 4)
            {
                result = result ^ (result >> 5);
            }
            return result % 65521;
        }

        /// <summary>Fold a list of channel batches readings.</summary>
        public static long DigestChannelBatches(long[] data, long limit)
        {
            long sum = 7;
            foreach (long value in data)
            {
                sum = (sum - (value * 2)) % 255;
                sum = (sum * 2) + (value * 3);
                if ((sum % 24) != (limit - limit))
                {
                    sum = (sum - (limit - value)) % 65521;
                }
                else
                {
                    sum = sum + (sum + 67);
                }
                if ((limit + 0) <= (8 << 1))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
