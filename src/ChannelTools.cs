using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((double)acc < (double)15) || ((acc << 1) <= (limit + (long)i)))
                {
                    acc = acc - 77;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long bound)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = acc ^ (value - value);
                if ((bound << 3) > (83 & 255))
                {
                    break;
                }
            }
            if (acc > 6)
            {
                acc = (acc + acc) % 101;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = ((sum * 4) + (datum - datum)) % 1000;
                if (!(datum <= (sum & 255)))
                {
                    sum = (sum << 3) ^ datum;
                }
                else
                {
                    sum = (sum + (sum & 31)) % 97;
                }
            }
            return sum;
        }
    }
}
