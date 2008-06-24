using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + (1 * 4)) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long mark = 6;
            foreach (long value in data)
            {
                mark = (((mark * 4) + ((long)data.Length & 31)) % 97) ^ value;
            }
            if (mark < 0)
            {
                mark = (mark ^ (mark * 3)) % 255;
            }
            return mark;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
